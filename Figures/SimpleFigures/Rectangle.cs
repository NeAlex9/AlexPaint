using BaseFigure;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace AlexPaint
{
    public class Rectangle : BaseSimpleFigures
    {


        public override void DrawFigure(Graphics g, Point clickedPoint)
        {
            Points.Add(new Point(xStart, yStart));
            Points.Add(new Point(clickedPoint.X, yStart));
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
            Points.Add(new Point(xStart, clickedPoint.Y));
            g.DrawPolygon(MyPen, Points.ToArray());
        }
    }
}