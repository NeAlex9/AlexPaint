using BaseFigure;
using System.Collections.Generic;
using System.Drawing;

namespace AllFigures
{
    public class Triangle : BaseSimpleFigures
    {
        public Triangle() {}

        public override void DrawFigure(Graphics g)
        {
            List<Point> temp = new List<Point>();
            if (startPoint.Y <= endPoint.Y)
            {
                temp.Add(new Point(startPoint.X, endPoint.Y));
                temp.Add(new Point(endPoint.X, endPoint.Y));
                if (startPoint.X <= endPoint.X)
                {
                    temp.Add(new Point((endPoint.X - startPoint.X) / 2 + startPoint.X, startPoint.Y));
                }
                else
                {
                    temp.Add(new Point((startPoint.X - endPoint.X) / 2 + endPoint.X, startPoint.Y));
                }
                g.DrawPolygon(MyPen, temp.ToArray());
            }
            else
            {
                temp.Add(new Point(startPoint.X, startPoint.Y));
                temp.Add(new Point(endPoint.X, startPoint.Y));
                if (startPoint.X <= endPoint.X)
                {
                    temp.Add(new Point((endPoint.X - startPoint.X) / 2 + startPoint.X, endPoint.Y));
                }
                else
                {
                    temp.Add(new Point((startPoint.X - endPoint.X) / 2 + endPoint.X, endPoint.Y));
                }
                g.DrawPolygon(MyPen, temp.ToArray());
            }
        }
    }
}