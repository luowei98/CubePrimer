using System;
using System.Runtime.InteropServices;
using System.Security;

namespace RobertLw.OpenGL.Windows
{
    partial class Wgl
    {
        internal static partial class Imports
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglCreateContext", ExactSpelling = true)]
            internal static extern IntPtr CreateContext(IntPtr hDc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglDeleteContext", ExactSpelling = true)]
            internal static extern bool DeleteContext(IntPtr oldContext);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglGetCurrentContext", ExactSpelling = true)]
            internal static extern IntPtr GetCurrentContext();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglMakeCurrent", ExactSpelling = true)]
            internal static extern bool MakeCurrent(IntPtr hDc, IntPtr newContext);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglCopyContext", ExactSpelling = true)]
            internal static extern bool CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglChoosePixelFormat", ExactSpelling = true)]
            internal static extern unsafe int ChoosePixelFormat(IntPtr hDc, Gdi.PixelFormatDescriptor* pPfd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglDescribePixelFormat", ExactSpelling = true)]
            internal static extern unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd,
                Gdi.PixelFormatDescriptor* ppfd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglGetCurrentDC", ExactSpelling = true)]
            internal static extern IntPtr GetCurrentDC();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglGetDefaultProcAddress", ExactSpelling = true)]
            internal static extern IntPtr GetDefaultProcAddress(string lpszProc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true)]
            internal static extern IntPtr GetProcAddress(string lpszProc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglGetPixelFormat", ExactSpelling = true)]
            internal static extern int GetPixelFormat(IntPtr hdc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglSetPixelFormat", ExactSpelling = true)]
            internal static extern unsafe bool SetPixelFormat(IntPtr hdc, int ipfd, Gdi.PixelFormatDescriptor* ppfd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglSwapBuffers", ExactSpelling = true)]
            internal static extern bool SwapBuffers(IntPtr hdc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglShareLists", ExactSpelling = true)]
            internal static extern bool ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglCreateLayerContext", ExactSpelling = true)]
            internal static extern IntPtr CreateLayerContext(IntPtr hDc, int level);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglDescribeLayerPlane", ExactSpelling = true)]
            internal static extern unsafe bool DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane,
                uint nBytes, Gdi.LayerPlaneDescriptor* plpd);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglSetLayerPaletteEntries", ExactSpelling = true)]
            internal static extern unsafe int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart,
                int cEntries, int* pcr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglGetLayerPaletteEntries", ExactSpelling = true)]
            internal static extern unsafe int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart,
                int cEntries, int* pcr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglRealizeLayerPalette", ExactSpelling = true)]
            internal static extern bool RealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglSwapLayerBuffers", ExactSpelling = true)]
            internal static extern bool SwapLayerBuffers(IntPtr hdc, uint fuFlags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglUseFontBitmapsA", CharSet = CharSet.Auto)]
            internal static extern bool UseFontBitmapsA(IntPtr hDC, int first, int count, int listBase);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglUseFontBitmapsW", CharSet = CharSet.Auto)]
            internal static extern bool UseFontBitmapsW(IntPtr hDC, int first, int count, int listBase);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglUseFontOutlinesA", CharSet = CharSet.Auto)]
            internal static extern unsafe bool UseFontOutlinesA(IntPtr hDC, int first, int count, int listBase,
                float thickness, float deviation, int fontMode, Gdi.GlyphMetricsFloat* glyphMetrics);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Library, EntryPoint = "wglUseFontOutlinesW", CharSet = CharSet.Auto)]
            internal static extern unsafe bool UseFontOutlinesW(IntPtr hDC, int first, int count, int listBase,
                float thickness, float deviation, int fontMode, Gdi.GlyphMetricsFloat* glyphMetrics);
        }
    }
}