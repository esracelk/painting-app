using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintingApp.Shapes
{
    public class RectangleShape : Shape
    {
 
        public override void Draw(Graphics g)
        {
            Rectangle rect = GetRectangle();

            using (SolidBrush brush = new SolidBrush(Color))
                g.FillRectangle(brush, rect);

            if (IsSelected)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    pen.DashStyle = DashStyle.Dot;
                    g.DrawRectangle(pen, rect);
                }
            }
        }

        public override bool Contains(Point p)
        {
            return GetRectangle().Contains(p);
        }

        private Rectangle GetRectangle()
        {
            return new Rectangle(
                Math.Min(StartPoint.X, EndPoint.X),
                Math.Min(StartPoint.Y, EndPoint.Y),
                Math.Abs(EndPoint.X - StartPoint.X),
                Math.Abs(EndPoint.Y - StartPoint.Y)
            );
        }
    }
}
