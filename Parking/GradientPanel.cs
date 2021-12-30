using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Parking
{
    public partial class GradientPanel : UserControl
    {
        int wh = 20;
        float ang = 45;

        Color col1 = Color.Blue;
        Color col2 = Color.Orange;
        readonly Timer t = new Timer();
        readonly Random rnd;
        readonly float k;
        string txt = "GradientPanel";

        public Color Color1
        {
            get { return col1; }
            set { col1 = value; Invalidate(); }
        }
        public Color Color2
        {
            get { return col2; }
            set { col2 = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }

        public string PanelText
        {
            get { return txt; }
            set { txt = value; Invalidate(); }
        }
        
        public GradientPanel()
        {
            DoubleBuffered = true;
            rnd = new Random();
            k = (float)rnd.NextDouble() / 2 - 1;
            k /= 10;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => { Angle = Angle % 360 + 0.03f + k; };
            ForeColor = Color.White;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddLine(new PointF(Width, Height), new PointF(0, Height));
            //gp.AddLine(new PointF(Height, Width), new PointF(Height, 0));


            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, col1, col2, (int)(Math.Sin(ang) * 60)), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            base.OnPaint(e);
        }
    }
}
