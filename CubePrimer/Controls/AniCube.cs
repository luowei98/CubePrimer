using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using RobertLw.OpenGL.Base;
using RobertLw.OpenGL.Windows;


namespace CubePrimer
{
    public partial class AniCube : SimpleOpenGlControl
    {
        #region private readonly fields
        private readonly float X_STA_ROT = 24.0f;
        private readonly float Y_STA_ROT = -35.0f;
        private readonly float Z_STA_ROT = 0.0f;
        private readonly float STA_ZOOM = -20.0f;

        #endregion

        #region private fields
        // texture
        private int[] texture = new int[1];

        // rotation
        private float xRot;
        private float yRot;
        private float zRot;
        private float xRotOff;
        private float yRotOff;
        private float zRotOff;

        // zoom
        private float depthZ;

        // animation
        private long lastMs;
        private float aniAngle;

        // mouser control
        private bool mouseLeftDown;
        private Point mouseOrigin;

        #endregion

        #region property
        private CubeData cubeData;
        public CubeData Data
        {
            get { return cubeData; }
            set
            {
                cubeData = value;
                if (cubeData != null)
                {
                    cubeData.OnValueChanged += (s, ea) => this.DrawGLScene();
                    cubeData.OnAtBegin += (s, ea) => this.DrawGLScene();
                    cubeData.OnAtEnd += (s, ea) => this.DrawGLScene();
                }
            }
        }

        public float AnimateSpeed { get; set; }

        public float Zoom
        {
            get { return depthZ; }
            set
            {
                depthZ = value;
                DrawGLScene();
            }
        }

        public MOVE_DIREC ContinueFlag { get; set; }

        public bool Ready
        {
            get { return !timerUpdate.Enabled; }
        }

        #endregion

        #region constructor method
        public AniCube()
        {
            InitializeComponent();
        }

        #endregion

        #region event
        private void AniCube_Load(object sender, EventArgs e)
        {
            InitGL();
            ReSizeGLScene(this.Width, this.Height);

            Init();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (lastMs == 0)
                lastMs = DateTime.Now.Ticks;
            long currentMs = DateTime.Now.Ticks;
            long milliseconds = (currentMs - lastMs) / 10000;
            lastMs = currentMs;

            aniAngle += (float)(milliseconds) / 20.0f * AnimateSpeed;
            if (aniAngle > (float)cubeData.MoveAngle)
            {
                InitAni();
                cubeData.Move();

                if (ContinueFlag == MOVE_DIREC.NEXT)
                    if (cubeData.GoNext())
                        Animate();
                    else
                        ContinueFlag = MOVE_DIREC.NONE;

                if (ContinueFlag == MOVE_DIREC.BACK)
                    if (cubeData.GoBack())
                        Animate();
                    else
                        ContinueFlag = MOVE_DIREC.NONE;
            }

            DrawGLScene();
        }

        private void AniCube_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseLeftDown = true;
                mouseOrigin = new Point(e.X, e.Y);
            }
        }

        private void AniCube_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseLeftDown)
            {
                xRotOff += (e.Y - mouseOrigin.Y) / 1.2f;
                yRotOff += (e.X - mouseOrigin.X) / 1.2f;
                DrawGLScene();
                mouseOrigin = new Point(e.X, e.Y);
            }
        }

        private void AniCube_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) mouseLeftDown = false;
        }

        #endregion

        #region override methods
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
                case Keys.Shift | Keys.Right:
                case Keys.Shift | Keys.Left:
                case Keys.Shift | Keys.Up:
                case Keys.Shift | Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawGLScene();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ReSizeGLScene(this.Width, this.Height);
        }

        #endregion

        #region public methods
        public void Reset()
        {
            Init();
            cubeData.Reset();
            DrawGLScene();
        }

        public void Animate()
        {
            lastMs = 0;
            timerUpdate.Start();
        }

        public void Rotate(float x, float y, float z)
        {
            xRotOff += x;
            yRotOff += y;
            zRotOff += z;



            DrawGLScene();
        }

        public void ZoomDelta(float dz)
        {
            depthZ += dz;
            DrawGLScene();
        }

        #endregion

        #region private function
        private void Init()
        {
            xRot = X_STA_ROT;
            yRot = Y_STA_ROT;
            zRot = Z_STA_ROT;
            xRotOff = 0.0f;
            yRotOff = 0.0f;
            zRotOff = 0.0f;

            depthZ = STA_ZOOM;

            AnimateSpeed = 5.0f;
            ContinueFlag = MOVE_DIREC.NONE;
            InitAni();
        }

        private void InitAni()
        {
            timerUpdate.Stop();

            lastMs = 0;
            aniAngle = 0.0f;
        }

        private bool InitGL()
        {
            base.InitializeContexts();

            Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glClearColor(0, 0, 0, 1.0f);
            Gl.glClearDepth(1);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glDepthFunc(Gl.GL_LEQUAL);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glHint(Gl.GL_PERSPECTIVE_CORRECTION_HINT, Gl.GL_NICEST);

            if (!LoadGLTextures())
                return false;

            return true;
        }

        private static void ReSizeGLScene(int width, int height)
        {
            if (width > height)
                Gl.glViewport(0, 0, width, height);
            else
                Gl.glViewport(0, (height - width) / 2, width, width);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            if (width > height)
                Glu.gluPerspective(30.0, width / (height == 0 ? 1.0 : (float)height), 0.1, 80.0);
            else
                Glu.gluPerspective(30.0, 1.0, 0.1, 80.0);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private float[] GetColor(int colorIdx)
        {
            Color c = Common.CurColor[colorIdx >= 0 && colorIdx <= 7 ? colorIdx : 7];
            return new float[] { (float)c.R / 0xff, (float)c.G / 0xff, (float)c.B / 0xff };
        }

        private bool LoadGLTextures()
        {
            Bitmap bitmap = null;
            BitmapData bitmapData = null;
            try
            {
                bitmap = Properties.Resources.face;
                bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
                Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);

                bitmapData = bitmap.LockBits(rectangle, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

                Gl.glGenTextures(1, texture);

                Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture[0]);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_LINEAR);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB8,
                                bitmap.Width, bitmap.Height,
                                0, Gl.GL_BGR, Gl.GL_UNSIGNED_BYTE, bitmapData.Scan0);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (bitmap != null)
                {
                    bitmap.UnlockBits(bitmapData);
                    bitmap.Dispose();
                }
            }
        }

        private bool DrawGLScene()
        {
            if (Data == null) return false;

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, texture[0]);


            for (int z = 0; z < 3; z++)
                for (int y = 0; y < 3; y++)
                    for (int x = 0; x < 3; x++)
                    {
                        Gl.glLoadIdentity();
                        Gl.glTranslatef(0.0f, 0.3f, depthZ);

                        Gl.glRotatef(xRot + xRotOff, 1.0f, 0.0f, 0.0f);
                        Gl.glRotatef(yRot + yRotOff, 0.0f, 1.0f, 0.0f);
                        Gl.glRotatef(zRot + zRotOff, 0.0f, 0.0f, 1.0f);

                        if (cubeData.MoveAxis == AXIS.X)
                        {
                            if (((int)Math.Pow(2, x) & (int)cubeData.MoveSide) > 0)
                                Gl.glRotatef(aniAngle * (int)cubeData.MoveDirection, 1.0f, 0.0f, 0.0f);
                        }
                        else if (cubeData.MoveAxis == AXIS.Y)
                        {
                            if (((int)Math.Pow(2, y) & (int)cubeData.MoveSide) > 0)
                                Gl.glRotatef(aniAngle * (int)cubeData.MoveDirection, 0.0f, 1.0f, 0.0f);
                        }
                        else if (cubeData.MoveAxis == AXIS.Z)
                        {
                            if (((int)Math.Pow(2, z) & (int)cubeData.MoveSide) > 0)
                                Gl.glRotatef(aniAngle * (int)cubeData.MoveDirection, 0.0f, 0.0f, 1.0f);
                        }

                        Gl.glTranslatef(x * 2 - 2, y * 2 - 2, z * 2 - 2);

                        Gl.glBegin(Gl.GL_QUADS);
                        // Front Face
                        Gl.glColor3fv(GetColor(cubeData.Face(x, y, z, POSITION.FRONT)));
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-1, -1, 1);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(1, -1, 1);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(1, 1, 1);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-1, 1, 1);
                        // Back Face
                        Gl.glColor3fv(GetColor(cubeData.Face(x, y, z, POSITION.BACK)));
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-1, -1, -1);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(-1, 1, -1);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(1, 1, -1);
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(1, -1, -1);
                        // Top Face
                        Gl.glColor3fv(GetColor(cubeData.Face(x, y, z, POSITION.TOP)));
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-1, 1, -1);
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-1, 1, 1);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(1, 1, 1);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(1, 1, -1);
                        // Bottom Face
                        Gl.glColor3fv(GetColor(cubeData.Face(x, y, z, POSITION.BOTTOM)));
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(-1, -1, -1);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(1, -1, -1);
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(1, -1, 1);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-1, -1, 1);
                        // Right face
                        Gl.glColor3fv(GetColor(cubeData.Face(x, y, z, POSITION.RIGHT)));
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(1, -1, -1);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(1, 1, -1);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(1, 1, 1);
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(1, -1, 1);
                        // Left Face
                        Gl.glColor3fv(GetColor(cubeData.Face(x, y, z, POSITION.LEFT)));
                        Gl.glTexCoord2f(0, 0); Gl.glVertex3f(-1, -1, -1);
                        Gl.glTexCoord2f(1, 0); Gl.glVertex3f(-1, -1, 1);
                        Gl.glTexCoord2f(1, 1); Gl.glVertex3f(-1, 1, 1);
                        Gl.glTexCoord2f(0, 1); Gl.glVertex3f(-1, 1, -1);
                        Gl.glEnd();
                    }

            Gl.glFlush();
            base.SwapBuffers();

            return true;
        }

        #endregion
    }
}
