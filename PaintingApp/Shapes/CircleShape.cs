using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintingApp.Shapes
{
    public class CircleShape : Shape
    {
       
        public override void Draw (Graphics g)
        {
            Rectangle circle = GetCircle();

            using (SolidBrush brush = new SolidBrush(Color))
                g.FillEllipse(brush, circle);

            if (IsSelected)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    pen.DashStyle = DashStyle.Dot;
                    g.DrawEllipse(pen, circle);
                }
            }
        }

        public override bool Contains(Point p)
        {
            return GetCircle().Contains(p);
        }

        private Rectangle GetCircle()
        {
            int centerX = StartPoint.X;
            int centerY = StartPoint.Y;

            int radius = (int)Math.Sqrt(
                     Math.Pow(EndPoint.X - StartPoint.X, 2)+
                     Math.Pow(EndPoint.Y - StartPoint.Y, 2));

            return new Rectangle(
                centerX - radius, 
                centerY - radius, 
                radius * 2, radius * 2
            );
        }
    }
}
