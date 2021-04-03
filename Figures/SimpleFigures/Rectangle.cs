using BaseFigure;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace AlexPaint
{
    public class Rectangle : BaseSimpleFigures
    {


        public override void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            Points.Add(new Point(xStart, yStart));
            Points.Add(new Point(e.X, yStart));
            Points.Add(new Point(e.X, e.Y));
            Points.Add(new Point(xStart, e.Y));
            g.DrawPolygon(myPen, Points.ToArray());
        }
    }
}