using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintingApp.Shapes
{
    public class HexagonShape : Shape
    {
        public override void Draw(Graphics g)
        {
            Point[] hexagon = GetHexagon();

            using (SolidBrush brush = new SolidBrush(Color))
                g.FillPolygon(brush, hexagon);

            if (IsSelected)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    pen.DashStyle = DashStyle.Dot;
                    g.DrawPolygon(pen, hexagon);
                }
            }
        }

        public override bool Contains(Point p)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(GetHexagon());
                return path.IsVisible(p);
            }
        }

        private Point[] GetHexagon()
        {
            int centerX = (StartPoint.X + EndPoint.X) / 2;
            int centerY = (StartPoint.Y + EndPoint.Y) / 2;
            int radius = Math.Min(Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y)) / 2;

            Point[] points = new Point[6];
            for (int i = 0; i < 6; i++)
            {
                double angle = Math.PI / 3 * i;
                points[i] = new Point(
                    centerX + (int)(radius * Math.Cos(angle)),
                    centerY + (int)(radius * Math.Sin(angle))
                );
            }
            return points;
        }
    }
}
