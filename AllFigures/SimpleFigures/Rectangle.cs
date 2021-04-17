using BaseFigure;
using System.Drawing;
using System;
using System.Collections.Generic;

namespace AllFigures
{
    public class Rectangle : BaseSimpleFigures
    {
        public Rectangle() { }        

        public override void DrawFigure(Graphics g)
        {
            List<Point> temp = new List<Point>();
            temp.Add(new Point(startPoint.X, startPoint.Y));
            temp.Add(new Point(endPoint.X, startPoint.Y));
            temp.Add(new Point(endPoint.X, endPoint.Y));
            temp.Add(new Point(startPoint.X, endPoint.Y));
            g.DrawPolygon(MyPen, temp.ToArray());
        }
    }
}