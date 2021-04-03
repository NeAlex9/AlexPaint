using BaseFigure;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace AlexPaint
{
    public class Rectangle : Figure
    {

        private int xStart;
        private int yStart;

        public Rectangle()
        {
            Points = new List<Point>();
        }

        public override void PrepareForDrawing(MouseEventArgs e, DrawingAssets assets)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                xStart = e.X;
                yStart = e.Y;
            }
        }

        public override void DrawWhileMouseMove(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                Graphics g = Graphics.FromImage(assets.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(assets.MainCanvas, 0, 0);
                Points.Clear();
                DrawFigure(g, e, assets.MyPen);
                DrawPanel.Image = assets.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        public void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            Points.Add(new Point(xStart, yStart));
            Points.Add(new Point(e.X, yStart));
            Points.Add(new Point(e.X, e.Y));
            Points.Add(new Point(xStart, e.Y));
            g.DrawPolygon(myPen, Points.ToArray());
        }

        public override void SetFigure(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                Graphics g = Graphics.FromImage(assets.MainCanvas);
                Points.Clear();
                DrawFigure(g, e, assets.MyPen);
                DrawPanel.Image = assets.MainCanvas;
                FinishPainting();
            }
        }

        /* public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
         {
             Points.Clear();
             Points.Add(new Point(xStart, yStart));
             Points.Add(new Point(e.X, yStart));
             Points.Add(new Point(e.X, e.Y));
             Points.Add(new Point(xStart, e.Y));
        g.DrawPolygon(myPen, Points.ToArray());

    }*/

        /*public override void LeftMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        {
            *//*xStart = xClick;
            yStart = yClick;
            CanvasWithOriginalFigure = originalCanvas;*//*
        }*/

        /* public override void LeftMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
         {
             Draw(g, e, myPen, xPrevClick, yPrevClick);
             Draw(g1, e, myPen, xPrevClick, yPrevClick);
    }

        public override void RightMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen)
        {

        }*/

        public override void FinishPainting()
        {
            Points.Clear();
        }
    }
}