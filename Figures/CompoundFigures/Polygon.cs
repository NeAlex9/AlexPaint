﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polygone : BaseCompoundFigure
    {
        private void FillFigure(Graphics g, List<Point> tempList, Pen myPen)
        {
            SolidBrush myBrush = new SolidBrush(Color.White);
            g.FillPolygon(myBrush, tempList.ToArray());
        }

        public override void LeftMouseUpClick(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
            Graphics g = Graphics.FromImage(assets.MainCanvas);
            int len = Points.Count, round = 20;
            if ((Points[0].X - round < Points[len - 1].X && Points[0].X + round > Points[len - 1].X) &&
                            (Points[0].Y - round < Points[len - 1].Y && Points[0].Y + round > Points[len - 1].Y))
            {
                Points[len - 1] = Points[0];
                Redraw(g);
                FinishPainting();
                DrawPanel.Image = assets.MainCanvas;
                return;
            }
            Redraw(g);
            DrawPanel.Image = assets.MainCanvas;
        }

        public override void RightMouseUpClick(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            Graphics g = Graphics.FromImage(assets.MainCanvas);
            Points.Add(new Point(Points[0].X, Points[0].Y));
            Redraw(g);
            DrawPanel.Image = assets.MainCanvas;
            FinishPainting();
        }

        public override void Redraw(Graphics g)
        {
            if (Points.Count > 0)
            {
                g.Clear(Color.White);
                g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
                FillFigure(g, Points, MyPen);
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    g.DrawLine(MyPen, Points[i], Points[i + 1]);
                }
            }
        }

        public override void BreakDraw(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            if (Points.Count > 0)
            {
                RightMouseUpClick(clickedPoint, assets, DrawPanel);
                FinishPainting();
            }

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




