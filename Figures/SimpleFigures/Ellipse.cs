using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Ellipse : BaseSimpleFigures
    {
        
        public override void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            int len = Points.Count;
            if (xStart <= e.X && yStart <= e.Y)
            {
                g.DrawEllipse(myPen, xStart, yStart, e.X - xStart, e.Y - yStart);
            }
            else if (xStart > e.X && yStart <= e.Y)
            {
                g.DrawEllipse(myPen, e.X, yStart, xStart - e.X, e.Y - yStart);
            }
            else if ((xStart <= e.X && yStart > e.Y))
            {
                g.DrawEllipse(myPen, xStart, e.Y, e.X - xStart, yStart - e.Y);
            }
            else if (xStart > e.X && yStart > e.Y)
            {
                g.DrawEllipse(myPen, e.X, e.Y, xStart - e.X, yStart - e.Y);
            }
        }

    }
}