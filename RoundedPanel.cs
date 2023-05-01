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

            //create method with params rectangle rect and int radius
            //declare var diameter equals to radius params * 2
            //declare var size equals to new Size intanse params diameter, diameter
            //declare var arc equals to new rectanglef intanse params rect.location, size;

            //declare var path equals to new intanse of graphicspath()
            //path start figure
            //path add arc (arc, 180, 90)
            //arc.x = rect.right - diameter
            //path add arc (arc, 270, 90)
            //arc.y = rect.bottom - diameter
            //path add arc (arc, 0, 90)
            //arc.x = rect.left
            //path add arc (arch, 90, 90)
            //close figure
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var path = RoundedPath(ClientRectangle, cornerRadius);
            Region = new Region(path);

            //set graphics smooting mode to anti alias
            //declare path variable equals to new intase of roundedpath(clientRectangle, corner radius)
            //set the region equals to new intanse with path

        }
    }
}