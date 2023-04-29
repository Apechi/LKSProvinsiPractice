using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace LKSProvFullSoft
{
    internal class RoundedPanel : Panel
    {
        private int cornerRadius = 10;

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                if (cornerRadius != value)
                {
                    cornerRadius = value;
                    Invalidate();
                }
            }
        }

        private static GraphicsPath RoundedPath(Rectangle rect, int radius)
        {
            var diameter = radius * 2;
            var size = new Size(diameter, diameter);
            var arc = new RectangleF(rect.Location, size);

            var path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var path = RoundedPath(ClientRectangle, cornerRadius);
            Region = new Region(path);
        }
    }
}