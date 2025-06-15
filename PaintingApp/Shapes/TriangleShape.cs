using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintingApp.Shapes
{
    public class TriangleShape : Shape
    {
        public override void Draw(Graphics g)
        {
            Point[] triangle = GetTriangle();

            using (SolidBrush brush = new SolidBrush(Color))
                g.FillPolygon(brush, triangle);

            if (IsSelected)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    pen.DashStyle = DashStyle.Dot;
                    g.DrawPolygon(pen, triangle);
                }
            }
        }

        public override bool Contains(Point p)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(GetTriangle());
                return path.IsVisible(p);
            }
        }
        private Point[] GetTriangle()
        {
            Point top = new Point((StartPoint.X + EndPoint.X) / 2, StartPoint.Y);
            Point left = new Point(StartPoint.X, EndPoint.Y);
            Point right = new Point(EndPoint.X, EndPoint.Y);
            return new Point[] { top, left, right };
        }
    }

}

