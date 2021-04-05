using BaseFigure;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Triangle : BaseSimpleFigures
    {
        public override void DrawFigure(Graphics g, Point clickedPoint, Pen myPen)
        {
            if (yStart <= clickedPoint.Y)
            {
                Points.Add(new Point(xStart, clickedPoint.Y));
                Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
                if (xStart <= clickedPoint.X)
                {
                    Points.Add(new Point((clickedPoint.X - xStart) / 2 + xStart, yStart));
                }
                else
                {
                    Points.Add(new Point((xStart - clickedPoint.X) / 2 + clickedPoint.X, yStart));
                }
                g.DrawPolygon(myPen, Points.ToArray());
            }
            else
            {
                Points.Add(new Point(xStart, yStart));
                Points.Add(new Point(clickedPoint.X, yStart));
                if (xStart <= clickedPoint.X)
                {
                    Points.Add(new Point((clickedPoint.X - xStart) / 2 + xStart, clickedPoint.Y));
                }
                else
                {
                    Points.Add(new Point((xStart - clickedPoint.X) / 2 + clickedPoint.X, clickedPoint.Y));
                }
                g.DrawPolygon(myPen, Points.ToArray());
            }
        }
    }

}