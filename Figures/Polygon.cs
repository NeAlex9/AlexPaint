using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polygone : Figure
    {
        public int NumSide { get; set; }
        public List<Point> Points { get; set; }

        public Polygone()
        {
            Points = new List<Point>();
        }

        private void FillAndRecoverFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            SolidBrush myBrush = new SolidBrush(Color.White);
            List<Point> tempList = new List<Point>();
            foreach (var item in Points)
            {
                tempList.Add(item);
            }
            tempList.Add(new Point(e.X, e.Y));
            g.FillPolygon(myBrush, tempList.ToArray());
            for (int i = 0; i < Points.Count - 1; i++)
            {
                g.DrawLine(myPen, Points[i], Points[i + 1]);
            }
        }

        public override void LeftMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        {
            if (Points.Count < 1)
            {
                CanvasWithOriginalFigure = originalCanvas;
                Points.Add(new Point(xClick, yClick));
                xStart = xClick;
                yStart = yClick;
            }
        }

        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xPrevClock, int yPrevClock)
        {
            int len = Points.Count;
            FillAndRecoverFigure(g, e, myPen);
            g.DrawLine(myPen, xPrevClock, yPrevClock, e.X, e.Y);
        }

        public override void LeftMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
        {
            Points.Add(new Point(e.X, e.Y));
            int len = Points.Count, round = 20;
            if (len > 1)
            {
                if ((Points[0].X - round < Points[len - 1].X && Points[0].X + round > Points[len - 1].X) &&
                                (Points[0].Y - round < Points[len - 1].Y && Points[0].Y + round > Points[len - 1].Y))
                {
                    Points[len - 1] = Points[0];
                    FinishPainting(g, g1, e, myPen);
                    return;
                }
                g.DrawLine(myPen, xPrevClick, yPrevClick, e.X, e.Y);
            }
            FillAndRecoverFigure(g, e, myPen);
            g1.DrawLine(myPen, xPrevClick, yPrevClick, e.X, e.Y);
            xStart = e.X;
            yStart = e.Y;
        }

        public override void RightMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {
            if (Points.Count > 1)
            {
                Points.Add(new Point(Points[0].X, Points[0].Y));
                FinishPainting(g, g1, e, myPen);
            }
            
        }

        public override void FinishPainting(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {
            FillAndRecoverFigure(g, e, myPen);
            g1 = g;
            Points.Clear();
        }
    }
}

/* TODO Правильный Многоугольник
 private void GetPointsForRegularPolygon(double angle)
{
    double j = 0;
    for (int i = 0; i < numSides + 1; i++)
    {
        arrPoints[i].X = x + (int) (Math.Round(Math.Cos(j / 180 * Math.PI) * r));
        arrPoints[i].Y = y - (int) (Math.Round(Math.Sin(j / 180 * Math.PI) * r));
        j = j + angle;
    }
}
public void DrawPolygon(PaintEventArgs e)
{
    Graphics g = e.Graphics;
    arrPoints = new Point[numSides + 1];
    GetPointsForPolygon((360.0 / numSides));
    Pen myPen = new Pen(Color.Black);
    g.DrawPolygon(myPen, arrPoints);
}*/