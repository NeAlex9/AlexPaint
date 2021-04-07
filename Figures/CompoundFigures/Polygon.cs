using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polygone : BaseCompoundFigure
    {
        public Polygone() : base() { }

        private Polygone(Polygone source, Bitmap MainCanvas) : base(source, MainCanvas)
        {
            List<Point> temp = new List<Point>();
            for (int i = 0; i < source.Points.Count; i++)
            {
                temp.Add(source.Points[i]);
            }
            this.Points = temp;
        }

        private void FillFigure(Graphics g, List<Point> tempList)
        {
            SolidBrush myBrush = new SolidBrush(Color.White);
            g.FillPolygon(myBrush, tempList.ToArray());
        }

        public override void LeftMouseUpClick(Graphics g, Point clickedPoint)
        {
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
            int len = Points.Count, round = 20;
            if ((Points[0].X - round < Points[len - 1].X && Points[0].X + round > Points[len - 1].X) &&
                            (Points[0].Y - round < Points[len - 1].Y && Points[0].Y + round > Points[len - 1].Y))
            {
                Points[len - 1] = Points[0];
                Redraw(g);
                HadTheFigureDrawn = true;
                return;
            }
            Redraw(g);
        }

        public override void RightMouseUpClick(Graphics g, Point clickedPoint)
        {
            if (Points.Count > 0)
            {
                Points.Add(new Point(Points[0].X, Points[0].Y));
                Redraw(g);
                HadTheFigureDrawn = true;
            }
        }

        public override void Redraw(Graphics g)
        {
            if (Points.Count > 0)
            {
                g.Clear(Color.White);
                g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
                FillFigure(g, Points);
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    g.DrawLine(MyPen, Points[i], Points[i + 1]);
                }
            }
        }

        public override void BreakDraw(Graphics g, Point clickedPoint)
        {
            if (Points.Count > 0)
            {
                RightMouseUpClick(g, clickedPoint);
                HadTheFigureDrawn = true;
                FinishDrawning();
            }

        }

        public override Figure Clone(Bitmap MainCanvas)
        {
            return new Polygone(this, MainCanvas);
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




