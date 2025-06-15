using System.Drawing;

namespace PaintingApp.Shapes
{
   public abstract class Shape
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public abstract void Draw(Graphics g);
        public abstract bool Contains(Point p);
        public virtual string Serialize()
        {
            return $"{GetType().Name},{StartPoint.X},{StartPoint.Y},{EndPoint.X},{EndPoint.Y},{Color.ToArgb()}";
        }

        public virtual void Move(int dx, int dy)
        {
            StartPoint = new Point(StartPoint.X + dx, StartPoint.Y + dy);
            EndPoint = new Point(EndPoint.X + dx, EndPoint.Y + dy);
        }
    }
}
