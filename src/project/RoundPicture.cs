using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WinFormsApp3
{
    class RoundPictureBox : PictureBox
    {
        public int CornerRadius { get; set; } = 20;
        public RoundPictureBox()
        {
            this.BackColor = Color.Transparent;
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
 
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            GraphicsPath path = GetRoundedRectPath(bounds, CornerRadius);
            this.Region = new Region(path);

            pe.Graphics.Clear(this.BackColor);

            if (this.Image != null)
            {
                int x = (this.Width - this.Image.Width) / 2;
                int y = (this.Height - this.Image.Height) / 2;
                pe.Graphics.DrawImage(this.Image, x, y, this.Image.Width, this.Image.Height);
            }

            using (Pen borderPen = new Pen(Color.Black, 10))
            {
                pe.Graphics.DrawPath(borderPen, path);
            }
        }
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));
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
    }
}
