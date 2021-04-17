using System.Collections.Generic;
using System.Drawing;
using BaseFigure;

namespace AllFigures
{
    public class Ellipse : BaseSimpleFigures
    {
        public override void DrawFigure(Graphics g)
        {
            if (startPoint.X <= endPoint.X && startPoint.Y <= endPoint.Y)
            {
                g.DrawEllipse(MyPen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            }
            else if (startPoint.X > endPoint.X && startPoint.Y <= endPoint.Y)
            {
                g.DrawEllipse(MyPen, endPoint.X, startPoint.Y, startPoint.X - endPoint.X, endPoint.Y - startPoint.Y);
            }
            else if ((startPoint.X <= endPoint.X && startPoint.Y > endPoint.Y))
            {
                g.DrawEllipse(MyPen, startPoint.X, endPoint.Y, endPoint.X - startPoint.X, startPoint.Y - endPoint.Y);
            }
            else if (startPoint.X > endPoint.X && startPoint.Y > endPoint.Y)
            {
                g.DrawEllipse(MyPen, endPoint.X, endPoint.Y, startPoint.X - endPoint.X, startPoint.Y - endPoint.Y);
            }
        }
    }
}