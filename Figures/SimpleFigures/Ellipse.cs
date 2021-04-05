using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Ellipse : BaseSimpleFigures
    {
        public override void DrawFigure(Graphics g, Point clickedPoint, Pen myPen)
        {
            int len = Points.Count;
            if (xStart <= clickedPoint.X && yStart <= clickedPoint.Y)
            {
                g.DrawEllipse(myPen, xStart, yStart, clickedPoint.X - xStart, clickedPoint.Y - yStart);
            }
            else if (xStart > clickedPoint.X && yStart <= clickedPoint.Y)
            {
                g.DrawEllipse(myPen, clickedPoint.X, yStart, xStart - clickedPoint.X, clickedPoint.Y - yStart);
            }
            else if ((xStart <= clickedPoint.X && yStart > clickedPoint.Y))
            {
                g.DrawEllipse(myPen, xStart, clickedPoint.Y, clickedPoint.X - xStart, yStart - clickedPoint.Y);
            }
            else if (xStart > clickedPoint.X && yStart > clickedPoint.Y)
            {
                g.DrawEllipse(myPen, clickedPoint.X, clickedPoint.Y, xStart - clickedPoint.X, yStart - clickedPoint.Y);
            }
        }
    }
}