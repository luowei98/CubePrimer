using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RobertLw.OpenGL.Base;

namespace RobertLw.OpenGL.Windows
{

    #region Class Documentation

    /// <summary>
    ///     Provides a simple OpenGL control allowing quick development of Windows Forms-based
    ///     OpenGL applications.
    /// </summary>

    #endregion Class Documentation
    public class SimpleOpenGlControl : UserControl
    {
        // --- Constructors & Destructors ---

        #region SimpleOpenGlControl()

        /// <summary>
        ///     Constructor.  Creates contexts and sets properties.
        /// </summary>
        public SimpleOpenGlControl()
        {
            InitializeStyles();
            InitializeComponent();
            InitializeBackground();
        }

        #endregion SimpleOpenGlControl()

        #region Protected Property Overloads

        #region CreateParams CreateParams

        /// <summary>
        ///     Overrides the control's class style parameters.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                var CS_VREDRAW = 0x1;
                var CS_HREDRAW = 0x2;
                var CS_OWNDC = 0x20;
                var cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CS_VREDRAW | CS_HREDRAW | CS_OWNDC;
                return cp;
            }
        }

        #endregion CreateParams CreateParams

        #endregion Protected Property Overloads

        #region Dispose(bool disposing)

        /// <summary>
        ///     Disposes the control.
        /// </summary>
        /// <param name="disposing">Was the disposed manually called?</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            DestroyContexts();
            base.Dispose(disposing);
        }

        #endregion Dispose(bool disposing)

        // --- Private Methods ---

        #region InitializeBackground()

        /// <summary>
        ///     Loads the bitmap from the assembly's manifest resource.
        /// </summary>
        private void InitializeBackground()
        {
            try
            {
                //Assembly assembly = Assembly.GetExecutingAssembly();
                //using(Stream imageStream = assembly.GetManifestResourceStream("xxx.jpg")) {
                //    if (imageStream != null) BackgroundImage = Image.FromStream(imageStream);
                //}
            }
            catch (Exception)
            {
                //e.ToString();
                BackgroundImage = null;
            }
        }

        #endregion InitializeBackground()

        #region InitializeComponent()

        /// <summary>
        ///     Required for designer support.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            // 
            // SimpleOpenGlControl
            // 
            BackColor = Color.Black;
            Size = new Size(50, 50);
        }

        #endregion InitializeComponent()

        #region InitializeStyles()

        /// <summary>
        ///     Initializes the control's styles.
        /// </summary>
        private void InitializeStyles()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, false);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        #endregion InitializeStyles()

        // --- Public Methods ---

        #region DestroyContexts()

        /// <summary>
        /// </summary>
        public void DestroyContexts()
        {
            if (renderingContext != IntPtr.Zero)
            {
                Wgl.wglMakeCurrent(IntPtr.Zero, IntPtr.Zero);
                Wgl.wglDeleteContext(renderingContext);
                renderingContext = IntPtr.Zero;
            }

            if (deviceContext != IntPtr.Zero)
            {
                if (windowHandle != IntPtr.Zero)
                {
                    User.ReleaseDC(windowHandle, deviceContext);
                }
                deviceContext = IntPtr.Zero;
            }
        }

        #endregion DestroyContexts()

        #region Draw()

        /// <summary>
        ///     Sends an see cref="UserControl.Invalidate"  command to this control, thus
        ///     forcing a redraw to occur.
        /// </summary>
        public void Draw()
        {
            Invalidate();
        }

        #endregion Draw()

        #region InitializeContexts()

        /// <summary>
        ///     Creates the OpenGL contexts.
        /// </summary>
        public void InitializeContexts()
        {
            windowHandle = Handle; // Get window handle

            if (windowHandle == IntPtr.Zero)
            {
                // No window handle means something is wrong
                MessageBox.Show("Window creation error.  No window handle.", "Fatal Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            var pfd = new Gdi.PixelFormatDescriptor(); // The pixel format descriptor
            pfd.nSize = (short) Marshal.SizeOf(pfd); // Size of the pixel format descriptor
            pfd.nVersion = 1; // Version number (always 1)
            pfd.dwFlags = Gdi.PFD_DRAW_TO_WINDOW | // Format must support windowed mode
                          Gdi.PFD_SUPPORT_OPENGL | // Format must support OpenGL
                          Gdi.PFD_DOUBLEBUFFER; // Must support double buffering
            pfd.iPixelType = Gdi.PFD_TYPE_RGBA; // Request an RGBA format
            pfd.cColorBits = ColorBits; // Select our color depth
            pfd.cRedBits = 0; // Individual color bits ignored
            pfd.cRedShift = 0;
            pfd.cGreenBits = 0;
            pfd.cGreenShift = 0;
            pfd.cBlueBits = 0;
            pfd.cBlueShift = 0;
            pfd.cAlphaBits = 0; // No alpha buffer
            pfd.cAlphaShift = 0; // Alpha shift bit ignored
            pfd.cAccumBits = AccumBits; // Accumulation buffer
            pfd.cAccumRedBits = 0; // Individual accumulation bits ignored
            pfd.cAccumGreenBits = 0;
            pfd.cAccumBlueBits = 0;
            pfd.cAccumAlphaBits = 0;
            pfd.cDepthBits = DepthBits; // Z-buffer (depth buffer)
            pfd.cStencilBits = StencilBits; // No stencil buffer
            pfd.cAuxBuffers = 0; // No auxiliary buffer
            pfd.iLayerType = Gdi.PFD_MAIN_PLANE; // Main drawing layer
            pfd.bReserved = 0; // Reserved
            pfd.dwLayerMask = 0; // Layer masks ignored
            pfd.dwVisibleMask = 0;
            pfd.dwDamageMask = 0;

            deviceContext = User.GetDC(windowHandle); // Attempt to get the device context
            if (deviceContext == IntPtr.Zero)
            {
                // Did we not get a device context?
                MessageBox.Show("Can not create a GL device context.", "Fatal Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            var pixelFormat = Gdi.ChoosePixelFormat(deviceContext, ref pfd);
            if (pixelFormat == 0)
            {
                // Did windows not find a matching pixel format?
                MessageBox.Show("Can not find a suitable PixelFormat.", "Fatal Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            if (!Gdi.SetPixelFormat(deviceContext, pixelFormat, ref pfd))
            {
                // Are we not able to set the pixel format?
                MessageBox.Show("Can not set the chosen PixelFormat.  Chosen PixelFormat was " + pixelFormat + ".",
                    "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            LogScaleX = Gdi.GetDeviceCaps(deviceContext, (int) Gdi.DEVCAPS.LOGPIXELSX);
                // Attempt to retrieve DPI-Setting 
            LogScaleY = Gdi.GetDeviceCaps(deviceContext, (int) Gdi.DEVCAPS.LOGPIXELSY);
                // Attempt to retrieve DPI-Setting 

            renderingContext = Wgl.wglCreateContext(deviceContext); // Attempt to get the rendering context
            if (renderingContext == IntPtr.Zero)
            {
                // Are we not able to get a rendering context?
                MessageBox.Show("Can not create a GL rendering context.", "Fatal Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }

            MakeCurrent(); // Attempt to activate the rendering context

            // Force A Reset On The Working Set Size
            Kernel.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
        }

        #endregion InitializeContexts()

        #region MakeCurrent()

        /// <summary>
        /// </summary>
        public void MakeCurrent()
        {
            // Are we not able to activate the rending context?
            //if(deviceContext == IntPtr.Zero || renderingContext == IntPtr.Zero || !Wgl.wglMakeCurrent(deviceContext, renderingContext)) {
            if (!Wgl.wglMakeCurrent(deviceContext, renderingContext))
            {
                MessageBox.Show("Can not activate the GL rendering context.", "Fatal Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

        #endregion MakeCurrent()

        #region SwapBuffers()

        /// <summary>
        /// </summary>
        public void SwapBuffers()
        {
            Gdi.SwapBuffersFast(deviceContext);
        }

        #endregion SwapBuffers()

        // --- Events ---

        #region OnPaint(PaintEventArgs e)

        /// <summary>
        ///     Paints the control.
        /// </summary>
        /// <param name="e">The paint event arguments.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (DesignMode)
            {
                e.Graphics.Clear(BackColor);
                if (BackgroundImage != null)
                    e.Graphics.DrawImage(BackgroundImage, ClientRectangle, 0, 0, BackgroundImage.Width,
                        BackgroundImage.Height, GraphicsUnit.Pixel);
                e.Graphics.Flush();
                return;
            }

            if (deviceContext == IntPtr.Zero || renderingContext == IntPtr.Zero)
            {
                MessageBox.Show("No device or rendering context available!");
                return;
            }

            if (AutoMakeCurrent)
            {
                MakeCurrent();
            }

            base.OnPaint(e);

            if (AutoFinish)
            {
                Gl.glFinish();
            }

            if (AutoCheckErrors)
            {
                errorCode = Gl.glGetError();
                if (errorCode != Gl.GL_NO_ERROR)
                {
                    switch (errorCode)
                    {
                        case Gl.GL_INVALID_ENUM:
                            MessageBox.Show(
                                "GL_INVALID_ENUM - An unacceptable value has been specified for an enumerated argument.  The offending function has been ignored.",
                                "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case Gl.GL_INVALID_VALUE:
                            MessageBox.Show(
                                "GL_INVALID_VALUE - A numeric argument is out of range.  The offending function has been ignored.",
                                "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case Gl.GL_INVALID_OPERATION:
                            MessageBox.Show(
                                "GL_INVALID_OPERATION - The specified operation is not allowed in the current state.  The offending function has been ignored.",
                                "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case Gl.GL_STACK_OVERFLOW:
                            MessageBox.Show(
                                "GL_STACK_OVERFLOW - This function would cause a stack overflow.  The offending function has been ignored.",
                                "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case Gl.GL_STACK_UNDERFLOW:
                            MessageBox.Show(
                                "GL_STACK_UNDERFLOW - This function would cause a stack underflow.  The offending function has been ignored.",
                                "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case Gl.GL_OUT_OF_MEMORY:
                            MessageBox.Show(
                                "GL_OUT_OF_MEMORY - There is not enough memory left to execute the function.  The state of OpenGL has been left undefined.",
                                "OpenGL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        default:
                            MessageBox.Show("Unknown GL error.  This should never happen.", "OpenGL Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                    }
                }
            }

            if (AutoSwapBuffers)
            {
                SwapBuffers();
            }
        }

        #endregion OnPaint(PaintEventArgs e)

        #region OnPaintBackground(PaintEventArgs e)

        /// <summary>
        ///     Paints the background.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }

        #endregion OnPaintBackground(PaintEventArgs e)

        // --- Fields ---

        #region Private Fields

        private IContainer components; // Required for designer support
        private IntPtr deviceContext = IntPtr.Zero; // GDI device context
        private IntPtr renderingContext = IntPtr.Zero; // Rendering context
        private IntPtr windowHandle = IntPtr.Zero; // Holds our window handle
        private int errorCode = Gl.GL_NO_ERROR; // The GL error code

        #endregion Private Fields

        #region Public Properties

        #region LogScaleX

        /// <summary>
        ///     Gets the number of logical pixels or dots per inch (dpi) in X-direction
        /// </summary>
        [Category("OpenGL Properties"), Description("Logical pixels per inch in X-direction.")]
        public int LogScaleX { get; private set; } = 96;

        #endregion

        #region LogScaleY

        /// <summary>
        ///     Gets the number of logical pixels or dots per inch (dpi) in Y-direction
        /// </summary>
        [Category("OpenGL Properties"), Description("Logical pixels per inch in Y-direction.")]
        public int LogScaleY { get; private set; } = 96;

        #endregion

        #region AccumBits

        /// <summary>
        ///     Gets and sets the OpenGL control's accumulation buffer depth.
        /// </summary>
        [Category("OpenGL Properties"), Description("Accumulation buffer depth in bits.")]
        public byte AccumBits { get; set; }

        #endregion AccumBits

        #region ColorBits

        /// <summary>
        ///     Gets and sets the OpenGL control's color buffer depth.
        /// </summary>
        [Category("OpenGL Properties"), Description("Color buffer depth in bits.")]
        public byte ColorBits { get; set; } = 32;

        #endregion ColorBits

        #region DepthBits

        /// <summary>
        ///     Gets and sets the OpenGL control's depth buffer (Z-buffer) depth.
        /// </summary>
        [Category("OpenGL Properties"), Description("Depth buffer (Z-buffer) depth in bits.")]
        public byte DepthBits { get; set; } = 16;

        #endregion DepthBits

        #region StencilBits

        /// <summary>
        ///     Gets and sets the OpenGL control's stencil buffer depth.
        /// </summary>
        [Category("OpenGL Properties"), Description("Stencil buffer depth in bits.")]
        public byte StencilBits { get; set; }

        #endregion StencilBits

        #region AutoCheckErrors

        /// <summary>
        ///     Gets and sets the OpenGL control's automatic sending of a glGetError command
        ///     after drawing.
        /// </summary>
        [Category("OpenGL Properties"), Description("Automatically send a glGetError command after drawing?")]
        public bool AutoCheckErrors { get; set; }

        #endregion AutoCheckErrors

        #region AutoFinish

        /// <summary>
        ///     Gets and sets the OpenGL control's automatic sending of a glFinish command
        ///     after drawing.
        /// </summary>
        [Category("OpenGL Properties"), Description("Automatically send a glFinish command after drawing?")]
        public bool AutoFinish { get; set; }

        #endregion AutoFinish

        #region AutoMakeCurrent

        /// <summary>
        ///     Gets and sets the OpenGL control's automatic forcing of the rendering context to
        ///     be current before drawing.
        /// </summary>
        [Category("OpenGL Properties"), Description("Automatically make the rendering context current before drawing?")]
        public bool AutoMakeCurrent { get; set; } = true;

        #endregion AutoMakeCurrent

        #region AutoSwapBuffers

        /// <summary>
        ///     Gets and sets the OpenGL control's automatic sending of a SwapBuffers command
        ///     after drawing.
        /// </summary>
        [Category("OpenGL Properties"), Description("Automatically send a SwapBuffers command after drawing?")]
        public bool AutoSwapBuffers { get; set; } = true;

        #endregion AutoSwapBuffers

        #endregion Public Properties
    }
}