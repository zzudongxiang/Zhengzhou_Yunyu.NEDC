using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEDC
{
    public partial class MyWave : PictureBox
    {
        public MyWave()
        {
            InitializeComponent();
        }

        public string Unit { get; set; }

        private double _MaxValue = 100;
        public double MaxValue
        {
            get { return _MaxValue; }
            set { _MaxValue = value; }
        }

        private double _MinValue = 0;
        public double MinValue
        {
            get { return _MinValue; }
            set { _MinValue = value; }
        }

        private int _ShowPointCount = 60;
        public int ShowPointCount
        {
            get { return _ShowPointCount; }
            set { _ShowPointCount = value; }
        }

        public bool Small { get; set; }

        public Color GridColor { get; set; }

        protected override void OnResize(EventArgs e)
        {
            try
            {
                base.OnResize(e);
                Bitmap bmp = new Bitmap(Width, Height);
                Graphics g = Graphics.FromImage(bmp);
                Pen pen = new Pen(GridColor);
                double d_Width = (double)Width / (ShowPointCount / 10);
                int W = (int)(d_Width * (ShowPointCount / 10));
                int H = (int)(d_Width * (Height / d_Width));
                int StartW = (Width - W) >> 1;
                int StartH = (Height - H) >> 1;
                Point[] Points = new Point[]
                {
                new Point(StartW, StartH),
                new Point(Width - StartW -1, StartH),
                new Point(Width - StartW -1, Height - StartH - 1),
                new Point(StartW, Height - StartH - 1),
                new Point(StartW, StartH)
                };
                g.DrawLines(pen, Points);
                if (!Small)
                {
                    int R = pen.Color.R;
                    int G = pen.Color.G;
                    int B = pen.Color.B;
                    pen.Dispose();
                    pen = new Pen(Color.FromArgb(80, R, G, B));
                    for (int i = 1; i < (ShowPointCount / 10); i++) g.DrawLine(pen, (int)(StartW + i * d_Width), StartH, (int)(StartW + i * d_Width), Height - StartH - 1);
                    for (int i = 1; i < (Height / d_Width); i++) g.DrawLine(pen, StartW, (int)(StartH + i * d_Width), Width - StartW - 1, (int)(StartH + i * d_Width));
                }
                pen.Dispose();
                g.Dispose();
                if (BackgroundImage != null) BackgroundImage.Dispose();
                BackgroundImage = bmp;
            }
            catch { }
        }

        public void Clear()
        {
            OnResize(null);
        }

        public void DrawLine(List<double> Points, List<double> OldPoints)
        {
            Bitmap bmp = new Bitmap(Math.Max(1, Width), Math.Max(1, Height));
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(GridColor);
            try
            {
                g.DrawLines(pen, GetPoints(Points));
                pen = new Pen(Color.FromArgb(100, pen.Color.R, pen.Color.G, pen.Color.B));
                g.DrawLines(pen, GetPoints(OldPoints));
            }
            catch { }
            finally
            {
                pen.Dispose();
                g.Dispose();
                if (Image != null) Image.Dispose();
                Image = bmp;
            }
        }

        private Point[] GetPoints(List<double> Points)
        {
            if (Points == null || Points.Count() < 2) return null;
            List<double> Temp = new List<double>(Points);
            int RemoveCount = Temp.Count() - ShowPointCount - 1;
            if (RemoveCount < 0) RemoveCount = 0;
            Temp.RemoveRange(0, RemoveCount);
            double d_Width = (double)Width / (ShowPointCount / 10);
            int W = (int)(d_Width * (ShowPointCount / 10));
            int H = (int)(d_Width * (Height / d_Width));
            int StartW = (Width - W) >> 1;
            int StartH = (Height - H) >> 1;
            double WidthPoint = d_Width / 10.0;
            List<Point> Rusult = new List<Point> { };
            int X = 0;
            foreach (double p in Temp)
                Rusult.Add(new Point(StartW + (int)(WidthPoint * (X++)), H - (int)((p - MinValue) / (MaxValue - MinValue) * (double)H) - StartH));
            Point[] Out = Rusult.ToArray();
            Rusult.Clear();
            return Out;
        }

    }
}
