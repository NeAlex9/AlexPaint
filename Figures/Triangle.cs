using BaseFigure;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Triangle : Figure
    {

        public List<Point> Points { set; get; }
        public Triangle()
        {
            Points = new List<Point>();
        }

        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
            Points.Clear();
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

        public override void LeftMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        {
            xStart = xClick;
            yStart = yClick;
            CanvasWithOriginalFigure = originalCanvas;
        }

        public override void LeftMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
        {
            Draw(g, e, myPen, xPrevClick, yPrevClick);
            Draw(g1, e, myPen, xPrevClick, yPrevClick);
        }

        public override void RightMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {

        }

        public override void FinishPainting(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {

        }
    }
}