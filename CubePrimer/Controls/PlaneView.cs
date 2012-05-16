using System;
using System.Drawing;
using System.Windows.Forms;

namespace CubePrimer
{
    public partial class PlaneView : UserControl
    {
        #region private readonly fields
        private readonly Point STARTP = new Point(1, 10);
        private readonly int FRAMESIZE = 1;
        private readonly Color FRAMECOLOR = Color.FromArgb(0xff, 0x33, 0x33, 0x33);

        private readonly Point[] MAP = 
        { // top
            new Point(3, 0), new Point(4, 0), new Point(5, 0),
            new Point(3, 1), new Point(4, 1), new Point(5, 1),
            new Point(3, 2), new Point(4, 2), new Point(5, 2),
            // bottom
            new Point(3, 6), new Point(4, 6), new Point(5, 6),
            new Point(3, 7), new Point(4, 7), new Point(5, 7),
            new Point(3, 8), new Point(4, 8), new Point(5, 8),
            // front
            new Point(3, 3), new Point(4, 3), new Point(5, 3),
            new Point(3, 4), new Point(4, 4), new Point(5, 4),
            new Point(3, 5), new Point(4, 5), new Point(5, 5),
            // back
            new Point(9, 3), new Point(10, 3), new Point(11, 3),
            new Point(9, 4), new Point(10, 4), new Point(11, 4),
            new Point(9, 5), new Point(10, 5), new Point(11, 5),
            // left
            new Point(0, 3), new Point(1, 3), new Point(2, 3),
            new Point(0, 4), new Point(1, 4), new Point(2, 4),
            new Point(0, 5), new Point(1, 5), new Point(2, 5),
            // right
            new Point(6, 3), new Point(7, 3), new Point(8, 3),
            new Point(6, 4), new Point(7, 4), new Point(8, 4),
            new Point(6, 5), new Point(7, 5), new Point(8, 5),
        };

        #endregion

        #region private fields
        private int boxSize;
        private Point[,] frameVertices;

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
                    cubeData.OnValueChanged += (s, ea) => this.Refresh();
                    cubeData.OnAtBegin += (s, ea) => this.Refresh();
                    cubeData.OnAtEnd += (s, ea) => this.Refresh();
                }
            }
        }

        #endregion

        #region constructor methods
        public PlaneView()
        {
            InitializeComponent();
        }

        #endregion

        #region event
        private void PlaneView_Load(object sender, EventArgs e)
        {
            ResizeBox();
        }

        private void PlaneView_Resize(object sender, EventArgs e)
        {
            ResizeBox();
            this.Refresh();
        }

        private void PlaneView_Paint(object sender, PaintEventArgs e)
        {
            if (Data != null && !string.IsNullOrEmpty(Data.Value))
            {
                // box
                SolidBrush b;
                for (int i = 0; i < 54; i++)
                {
                    b = new SolidBrush(GetColor(Data.Value[i]));
                    e.Graphics.FillRectangle(b, GetRect(i));
                }
            }

            // frame
            Pen p = new Pen(FRAMECOLOR, FRAMESIZE);

            e.Graphics.DrawLine(p, frameVertices[3, 0], frameVertices[6, 0]);
            e.Graphics.DrawLine(p, frameVertices[3, 1], frameVertices[6, 1]);
            e.Graphics.DrawLine(p, frameVertices[3, 2], frameVertices[6, 2]);

            e.Graphics.DrawLine(p, frameVertices[0, 3], frameVertices[12, 3]);
            e.Graphics.DrawLine(p, frameVertices[0, 4], frameVertices[12, 4]);
            e.Graphics.DrawLine(p, frameVertices[0, 5], frameVertices[12, 5]);
            e.Graphics.DrawLine(p, frameVertices[0, 6], frameVertices[12, 6]);

            e.Graphics.DrawLine(p, frameVertices[3, 7], frameVertices[6, 7]);
            e.Graphics.DrawLine(p, frameVertices[3, 8], frameVertices[6, 8]);
            e.Graphics.DrawLine(p, frameVertices[3, 9], frameVertices[6, 9]);

            e.Graphics.DrawLine(p, frameVertices[0, 3], frameVertices[0, 6]);
            e.Graphics.DrawLine(p, frameVertices[1, 3], frameVertices[1, 6]);
            e.Graphics.DrawLine(p, frameVertices[2, 3], frameVertices[2, 6]);

            e.Graphics.DrawLine(p, frameVertices[3, 0], frameVertices[3, 9]);
            e.Graphics.DrawLine(p, frameVertices[4, 0], frameVertices[4, 9]);
            e.Graphics.DrawLine(p, frameVertices[5, 0], frameVertices[5, 9]);
            e.Graphics.DrawLine(p, frameVertices[6, 0], frameVertices[6, 9]);

            e.Graphics.DrawLine(p, frameVertices[7, 3], frameVertices[7, 6]);
            e.Graphics.DrawLine(p, frameVertices[8, 3], frameVertices[8, 6]);
            e.Graphics.DrawLine(p, frameVertices[9, 3], frameVertices[9, 6]);

            e.Graphics.DrawLine(p, frameVertices[10, 3], frameVertices[10, 6]);
            e.Graphics.DrawLine(p, frameVertices[11, 3], frameVertices[11, 6]);
            e.Graphics.DrawLine(p, frameVertices[12, 3], frameVertices[12, 6]);

        }

        #endregion

        #region private function
        private void ResizeBox()
        {
            boxSize = Math.Min((this.ClientSize.Width - FRAMESIZE * 13 - STARTP.X * 2) / 12,
                               (this.ClientSize.Height - FRAMESIZE * 10 - STARTP.Y * 2) / 9);
            CalcVertex();
        }

        private void CalcVertex()
        {
            int sz = boxSize + FRAMESIZE;
            frameVertices = new Point[13, 10];
            for (int y = 0; y < 10; y++)
                for (int x = 0; x < 13; x++)
                    frameVertices[x, y] = new Point(STARTP.X + x * sz, STARTP.Y + y * sz);
        }

        private Rectangle GetRect(int i)
        {
            Point p = MAP[i];
            return new Rectangle(frameVertices[p.X, p.Y].X + 1, frameVertices[p.X, p.Y].Y + 1, boxSize, boxSize);
        }

        private Color GetColor(char c)
        {
            int i = (int)c - 48;
            return Common.CurColor[i];
        }

        #endregion
    }
}
