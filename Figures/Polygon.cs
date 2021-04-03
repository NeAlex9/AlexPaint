using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polygone : Figure
    {
        public int NumSide { get; set; }
        public Bitmap CanvasWithUnfilledFigure { get; set; }
        public Bitmap CanvasWithoutCurrentFigure { set; get; }

        public Polygone()
        {
            CanvasWithUnfilledFigure = new Bitmap(1920, 1080);
        }

        private void FillFigure(Graphics g, List<Point> tempList, Pen myPen)
        {
            SolidBrush myBrush = new SolidBrush(Color.White);
            g.FillPolygon(myBrush, tempList.ToArray());
        }

        private void RecoverFigure(Graphics g, Pen myPen)
        {
            for (int i = 0; i < Points.Count - 1; i++)
            {
                g.DrawLine(myPen, Points[i], Points[i + 1]);
            }
        }

        public override void PrepareForDrawing(MouseEventArgs e, DrawingAssets assets)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                if (assets.CurrentFigure.Points.Count < 1)
                {
                    Points.Add(new Point(e.X, e.Y));
                    CanvasWithUnfilledFigure = (Bitmap)assets.MainCanvas.Clone();
                    CanvasWithoutCurrentFigure = (Bitmap)assets.MainCanvas.Clone();
                }
            }
        }

        public override void DrawWhileMouseMove(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Graphics g = Graphics.FromImage(assets.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(CanvasWithUnfilledFigure, 0, 0);
                DrawFigure(g, e, assets.MyPen);
                DrawPanel.Image = assets.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        public void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            int len = Points.Count;
            List<Point> temp = new List<Point>(Points);
            temp.Add(new Point(e.X, e.Y));
            FillFigure(g, temp, myPen);
            RecoverFigure(g, myPen);
            g.DrawLine(myPen, Points[len - 1].X, Points[len - 1].Y, e.X, e.Y);
        }

        public override void SetFigure(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                LeftMouseUpClick(e, assets, DrawPanel);
            }
            if (((e.Button & MouseButtons.Right) != 0) && (Points.Count > 2))
            {
                RightMouseUpClick(e, assets, DrawPanel);
                FinishPainting();
            }
        }

        public void LeftMouseUpClick(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            Points.Add(new Point(e.X, e.Y));
            assets.MainCanvas = (Bitmap)CanvasWithUnfilledFigure.Clone();
            Graphics g = Graphics.FromImage(assets.MainCanvas);
            Graphics g1 = Graphics.FromImage(CanvasWithUnfilledFigure);
            List<Point> temp;
            int len = Points.Count, round = 20;
            if (len > 1)
            {
                if ((Points[0].X - round < Points[len - 1].X && Points[0].X + round > Points[len - 1].X) &&
                                (Points[0].Y - round < Points[len - 1].Y && Points[0].Y + round > Points[len - 1].Y))
                {
                    Points[len - 1] = Points[0];
                    temp = new List<Point>(Points);
                    temp.Add(new Point(e.X, e.Y));
                    FillFigure(g, temp, assets.MyPen);
                    RecoverFigure(g, assets.MyPen);
                    g1 = g;
                    FinishPainting();
                    DrawPanel.Image = assets.MainCanvas;
                    return;
                }
                g.DrawLine(assets.MyPen, Points[len - 2].X, Points[len - 2].Y, e.X, e.Y);
            }
            temp = new List<Point>(Points);
            temp.Add(new Point(e.X, e.Y));
            FillFigure(g, temp, assets.MyPen);
            RecoverFigure(g, assets.MyPen);
            g1.DrawLine(assets.MyPen, Points[len - 2].X, Points[len - 2].Y, e.X, e.Y);
            DrawPanel.Image = assets.MainCanvas;
        }

        public void RightMouseUpClick(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            assets.MainCanvas = (Bitmap)CanvasWithUnfilledFigure.Clone();
            Graphics g = Graphics.FromImage(assets.MainCanvas);
            Graphics g1 = Graphics.FromImage(CanvasWithUnfilledFigure);
            Points.Add(new Point(Points[0].X, Points[0].Y));
            var temp = new List<Point>(Points);
            temp.Add(new Point(e.X, e.Y));
            FillFigure(g, temp, assets.MyPen);
            RecoverFigure(g, assets.MyPen);
            g1 = g;
            DrawPanel.Image = assets.MainCanvas;
        }

        public override void Redraw(Graphics g, Pen myPen)
        {
            if (Points.Count > 0)
            {
                g.Clear(Color.White);
                g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
                var temp = new List<Point>(Points);
                FillFigure(g, temp, myPen);
                RecoverFigure(g, myPen);
                var g1 = Graphics.FromImage(CanvasWithUnfilledFigure);
                g1.Clear(Color.White);
                g1.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
                RecoverFigure(g1, myPen);
            }
        }

        public override void FinishPainting()
        {
            Points.Clear();
        }

        public override void BreakDraw(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if (Points.Count > 0)
            {
                RightMouseUpClick(e, assets, DrawPanel);
                FinishPainting();
            }

        }

        public override void Reset(KeyPressEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if (Convert.ToInt32(e.KeyChar) == 27 && Points.Count > 0)
            {
                assets.MainCanvas = (Bitmap)CanvasWithoutCurrentFigure.Clone();
                DrawPanel.Image = assets.MainCanvas;
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




