#region License

/*

MIT License
Copyright (c) 2004  Vladimir Vukicevic  <vladimir@pobox.com>
http://www.taoframework.com
All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

#endregion License

using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Tao.OpenGl
{
    //
    // This attribute is used to decorate OpenGL extension entry points.
    // It specifies both the extension name (full name, with GL_ prefix)
    // as well as the library entry point that should be queried for a
    // a particular method.  The field it's applied to will receive the
    // address of the function, whereas the method is only used before
    // postprocessing to tie a particular method with a particular extension.
    //
    /// <summary>
    /// </summary>
    [Obsolete("This attribute is obsolete. Extension loading is now handled by the Tao.OpenGl.Gl class")]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Method)]
    public class OPEN_GL_EXTENSION_IMPORT : Attribute
    {
        /// <summary>
        /// </summary>
        public string EntryPoint;

        /// <summary>
        /// </summary>
        public string ExtensionName;

        /// <summary>
        /// </summary>
        /// <param name="extensionName"></param>
        /// <param name="entryPoint"></param>
        public OPEN_GL_EXTENSION_IMPORT(string extensionName, string entryPoint)
        {
            ExtensionName = extensionName;
            EntryPoint = entryPoint;
        }
    }

    //
    // The GlExtensionLoader singleton, available through GetInstance(),
    // is responsible for loading extensions.
    //
    /// <summary>
    /// </summary>
    [Obsolete("This class is obsolete. Extension loading is now handled by the Tao.OpenGl.Gl class")]
    public class GlExtensionLoader
    {
        // key -> GlContextInfo
        // 0 is special key for the static context
        private static readonly Hashtable ContextInfo;

        private static GetProcAddressPlatform gpaPlatform = GetProcAddressPlatform.Unknown;

        //
        // Find the Tao.OpenGl.Gl type
        //
        private static Type mStaticGlType;

        static GlExtensionLoader()
        {
            ContextInfo = new Hashtable();
        }

        private GlExtensionLoader()
        {
        }

        private static Type StaticGlType
        {
            get
            {
                if (mStaticGlType != null)
                    return mStaticGlType;

                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    mStaticGlType = asm.GetType("Tao.OpenGl.Gl");
                    if (mStaticGlType != null)
                        return mStaticGlType;
                }

                throw new InvalidProgramException("Can't find Tao.OpenGl.Gl type in any loaded assembly!");
            }
        }

        // we can't depend on any symbols from Tao.OpenGl.Gl

        // linux
        [DllImport("libGL.so", EntryPoint = "glXGetProcAddress")]
        internal static extern IntPtr glxGetProcAddress(string s);

        // also linux, for our ARB-y friends
        [DllImport("libGL.so", EntryPoint = "glXGetProcAddressARB")]
        internal static extern IntPtr glxGetProcAddressARB(string s);

        // windows
        [DllImport("opengl32.dll", EntryPoint = "wglGetProcAddress")]
        internal static extern IntPtr wglGetProcAddress(string s);

        // osx gets complicated
        [DllImport("libdl.dylib", EntryPoint = "NSIsSymbolNameDefined")]
        internal static extern bool NSIsSymbolNameDefined(string s);

        [DllImport("libdl.dylib", EntryPoint = "NSLookupAndBindSymbol")]
        internal static extern IntPtr NSLookupAndBindSymbol(string s);

        [DllImport("libdl.dylib", EntryPoint = "NSAddressOfSymbol")]
        internal static extern IntPtr NSAddressOfSymbol(IntPtr symbol);

        // we can't depend on Tao.OpenGl.Gl for this

        [DllImport("opengl32.dll")]
        internal static extern IntPtr glGetString(uint name);

        internal static IntPtr AglGetProcAddress(string s)
        {
            var fname = "_" + s;
            if (!NSIsSymbolNameDefined(fname))
                return IntPtr.Zero;

            var symbol = NSLookupAndBindSymbol(fname);
            if (symbol != IntPtr.Zero)
                symbol = NSAddressOfSymbol(symbol);

            return symbol;
        }

        internal static GlContextInfo GetContextInfo(object ctx)
        {
            // use "0" to mean no context
            if (ctx == null)
                ctx = 0;

            if (!ContextInfo.ContainsKey(ctx))
            {
                ContextInfo[ctx] = new GlContextInfo();
            }

            return ContextInfo[ctx] as GlContextInfo;
        }

        /// <summary>
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static IntPtr GetProcAddress(string s)
        {
            if (gpaPlatform == GetProcAddressPlatform.Unknown)
            {
                IntPtr result;

                // WGL?
                try
                {
                    result = wglGetProcAddress(s);
                    gpaPlatform = GetProcAddressPlatform.Windows;
                    return result;
                }
                catch (Exception)
                {
                    // ignored
                }

                // AGL? (before X11, since GLX might exist on OSX)
                try
                {
                    result = AglGetProcAddress(s);
                    gpaPlatform = GetProcAddressPlatform.OSX;
                    return result;
                }
                catch (Exception)
                {
                    // ignored
                }

                // X11?
                try
                {
                    result = glxGetProcAddress(s);
                    gpaPlatform = GetProcAddressPlatform.X11;
                    return result;
                }
                catch (Exception)
                {
                    // ignored
                }

                // X11 ARB?
                try
                {
                    result = glxGetProcAddressARB(s);
                    gpaPlatform = GetProcAddressPlatform.X11_ARB;
                    return result;
                }
                catch (Exception)
                {
                    // ignored
                }

                // Ack!
                throw new NotSupportedException("Can't figure out how to call GetProcAddress on this platform!");
            }
            if (gpaPlatform == GetProcAddressPlatform.Windows)
            {
                return wglGetProcAddress(s);
            }
            if (gpaPlatform == GetProcAddressPlatform.OSX)
            {
                return AglGetProcAddress(s);
            }
            if (gpaPlatform == GetProcAddressPlatform.X11)
            {
                return glxGetProcAddress(s);
            }
            if (gpaPlatform == GetProcAddressPlatform.X11_ARB)
            {
                return glxGetProcAddressARB(s);
            }

            throw new NotSupportedException("Shouldn't get here..");
        }

        /// <summary>
        ///     Returns trueif the extension with the given name is supported
        ///     in the global static context.
        /// </summary>
        /// <param name="extname">The extension name.</param>
        /// <returns></returns>
        public static bool IsExtensionSupported(string extname)
        {
            return IsExtensionSupported(null, extname);
        }

        /// <summary>
        ///     Returns true if the extension with the given name is supported
        ///     in the given context.
        /// </summary>
        /// <param name="contextGl">The context which to query.</param>
        /// <param name="extname">The extension name.</param>
        /// <returns></returns>
        public static bool IsExtensionSupported(object contextGl, string extname)
        {
            var gci = GetContextInfo(contextGl);
            if (gci.AvailableExtensions.ContainsKey(extname))
                return true;
            return false;
        }

        /// <summary>
        ///     Attempt to load the extension with the specified name into the
        ///     global static context.  Returns true on success.
        /// </summary>
        /// <param name="extname">The extension name.</param>
        /// <returns></returns>
        public static bool LoadExtension(string extname)
        {
            return LoadExtension(null, extname, false);
        }

        //
        // LoadExtension
        //
        // Attempt to load the extension with the specified name into the
        // given context, which must have already been made current.  The
        // object passed in ought to be an instance of
        // Tao.OpenGl.ContextGl, or null.
        //
        /// <summary>
        /// </summary>
        /// <param name="contextGl"></param>
        /// <param name="extname"></param>
        /// <returns></returns>
        public static bool LoadExtension(object contextGl, string extname)
        {
            return LoadExtension(contextGl, extname, false);
        }

        //
        // LoadExtension
        //
        // Attempt to load the extension with the specified name into the
        // given context, which must have already been made current.  The
        // object passed in ought to be an instance of
        // Tao.OpenGl.ContextGl, or null. If forceLoad is set, attempt
        // to obtain function pointers even if the runtime claims that the
        // extension is not supported.
        //
        /// <summary>
        /// </summary>
        /// <param name="contextGl"></param>
        /// <param name="extname"></param>
        /// <param name="forceLoad"></param>
        /// <returns></returns>
        public static bool LoadExtension(object contextGl, string extname, bool forceLoad)
        {
            var gci = GetContextInfo(contextGl);
            if (gci.LoadedExtensions.ContainsKey(extname))
            {
                return (bool) gci.LoadedExtensions[extname];
            }

            if (!forceLoad && !gci.AvailableExtensions.ContainsKey(extname))
            {
                return false;
            }

            // this will get us either the Tao.OpenGl.Gl or
            // Tao.OpenGl.ContextGl class
            Type glt;
            if (contextGl != null)
            {
                glt = contextGl.GetType();
            }
            else
            {
                glt = StaticGlType;
                if (glt == null)
                {
                    Console.WriteLine("GL type is null!");
                }
            }

            var fis = glt?.GetFields(BindingFlags.Public |
                                     BindingFlags.DeclaredOnly |
                                     BindingFlags.Static |
                                     BindingFlags.Instance);

            if (fis != null)
                foreach (var fi in fis)
                {
                    var attrs = fi.GetCustomAttributes(typeof (OPEN_GL_EXTENSION_IMPORT), false);
                    if (attrs.Length == 0)
                        continue;

                    var oglext = attrs[0] as OPEN_GL_EXTENSION_IMPORT;
                    if (oglext?.ExtensionName == extname)
                    {
                        // did we already load this somehow?
                        if ((IntPtr) fi.GetValue(contextGl) != IntPtr.Zero)
                            continue;

                        //Console.WriteLine ("Loading " + oglext.entryPoint + " for " + extname);
                        var procaddr = GetProcAddress(oglext?.EntryPoint);
                        if (procaddr == IntPtr.Zero)
                        {
                            Console.WriteLine(
                                "OpenGL claimed that '{0}' was supported, but couldn't find '{1}' entry point",
                                extname, oglext?.EntryPoint);
                            // we crash if anyone tries to call this method, but that's ok
                            continue;
                        }

                        fi.SetValue(contextGl, procaddr);
                    }
                }

            if (extname != null) gci.LoadedExtensions[extname] = true;
            return true;
        }

        //
        // LoadAllExtensions
        //

        /// <summary>
        /// </summary>
        public static void LoadAllExtensions()
        {
            LoadAllExtensions(null);
        }

        /// <summary>
        /// </summary>
        /// <param name="contextGl"></param>
        public static void LoadAllExtensions(object contextGl)
        {
            var gci = GetContextInfo(contextGl);

            foreach (string ext in gci.AvailableExtensions.Keys)
                LoadExtension(contextGl, ext, false);
        }

        //
        // Data for a particular context; available extensions,
        // already-loaded extensions, etc.
        //

        internal class GlContextInfo
        {
            public Hashtable AvailableExtensions;
            public Hashtable LoadedExtensions;

            public GlContextInfo()
            {
                AvailableExtensions = new Hashtable();
                LoadedExtensions = new Hashtable();

                ParseAvailableExtensions();
            }

            public void ParseAvailableExtensions()
            {
                // assumes that the context is already made current
                var extstrptr = glGetString(0x00001f03); // GL_EXTENSIONS
                if (extstrptr == IntPtr.Zero)
                    return; // no extensions are available

                var extstr = Marshal.PtrToStringAnsi(extstrptr);

                if (extstr != null)
                {
                    var exts = extstr.Split(' ');
                    foreach (var ext in exts)
                    {
                        AvailableExtensions[ext] = true;
                    }
                }

                var verstrptr = glGetString(0x1F02); // GL_VERSION
                if (verstrptr == IntPtr.Zero)
                    return; // this shoudn't happen

                var ptrToStringAnsi = Marshal.PtrToStringAnsi(verstrptr);
                if (ptrToStringAnsi != null)
                {
                    var verstr = ptrToStringAnsi.Trim(' ');

                    if (verstr.StartsWith("1.2"))
                    {
                        AvailableExtensions["GL_VERSION_1_2"] = true;
                    }
                    else if (verstr.StartsWith("1.3"))
                    {
                        AvailableExtensions["GL_VERSION_1_2"] = true;
                        AvailableExtensions["GL_VERSION_1_3"] = true;
                    }
                    else if (verstr.StartsWith("1.4"))
                    {
                        AvailableExtensions["GL_VERSION_1_2"] = true;
                        AvailableExtensions["GL_VERSION_1_3"] = true;
                        AvailableExtensions["GL_VERSION_1_4"] = true;
                    }
                    else if (verstr.StartsWith("1.5"))
                    {
                        AvailableExtensions["GL_VERSION_1_2"] = true;
                        AvailableExtensions["GL_VERSION_1_3"] = true;
                        AvailableExtensions["GL_VERSION_1_4"] = true;
                        AvailableExtensions["GL_VERSION_1_5"] = true;
                    }
                    else if (verstr.StartsWith("2"))
                    {
                        AvailableExtensions["GL_VERSION_1_2"] = true;
                        AvailableExtensions["GL_VERSION_1_3"] = true;
                        AvailableExtensions["GL_VERSION_1_4"] = true;
                        AvailableExtensions["GL_VERSION_1_5"] = true;
                        AvailableExtensions["GL_VERSION_2_0"] = true;
                    }
                }
            }
        }

        //
        // the public entry point for a cross-platform GetProcAddress
        //
        private enum GetProcAddressPlatform
        {
            Unknown,
            Windows,
            X11,
            X11_ARB,
            OSX
        }
    }
}