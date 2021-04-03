using BaseFigure;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Triangle : BaseSimpleFigures
    {

        public override void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            if (yStart <= e.Y)
            {
                Points.Add(new Point(xStart, e.Y));
                Points.Add(new Point(e.X, e.Y));
                if (xStart <= e.X)
                {
                    Points.Add(new Point((e.X - xStart) / 2 + xStart, yStart));
                }
                else
                {
                    Points.Add(new Point((xStart - e.X) / 2 + e.X, yStart));
                }
                g.DrawPolygon(myPen, Points.ToArray());
            }
            else
            {
                Points.Add(new Point(xStart, yStart));
                Points.Add(new Point(e.X, yStart));
                if (xStart <= e.X)
                {
                    Points.Add(new Point((e.X - xStart) / 2 + xStart, e.Y));
                }
                else
                {
                    Points.Add(new Point((xStart - e.X) / 2 + e.X, e.Y));
                }
                g.DrawPolygon(myPen, Points.ToArray());
            }
        }

        public override void Redraw(Graphics g, Pen myPen)
        {

        }

        public override void BreakDraw(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {

        }
    
    }

}