﻿using PaintingApp.Shapes;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace PaintingApp.Helpers
{
    public static class ShapeSerializer
    {
        public static void Save(List<Shape> shapes, string filePath)
        {
            var lines = shapes.Select(s => s.Serialize()); 
            File.WriteAllLines(filePath, lines);
        }

        public static List<Shape> Load(string filePath)
        {

            var shapes = new List<Shape>();
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length != 6) continue;

                string type = parts[0];
                int x1 = int.Parse(parts[1]);
                int y1 = int.Parse(parts[2]);
                int x2 = int.Parse(parts[3]);
                int y2 = int.Parse(parts[4]);
                Color color = Color.FromArgb(int.Parse(parts[5]));

                Shape shape = null;

                if (type == "RectangleShape")
                {
                    shape = new RectangleShape();
                }
                else if (type == "CircleShape")
                {
                    shape = new CircleShape();
                }
                else if (type == "TriangleShape")
                {
                    shape = new TriangleShape();
                }
                else if (type == "HexagonShape")
                {
                    shape = new HexagonShape();
                }

                if (shape != null)
                {
                    shape.StartPoint = new Point(x1, y1);
                    shape.EndPoint = new Point(x2, y2);
                    shape.Color = color;
                    shapes.Add(shape);
                }
            }
            return shapes;
        }
    }
}