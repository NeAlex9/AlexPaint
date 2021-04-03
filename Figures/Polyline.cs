using System;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polyline : Figure
    {

        public Bitmap CanvasWithoutCurrentFigure { set; get; }

        public Polyline()
        {
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
                g.DrawImage(assets.MainCanvas, 0, 0);
                DrawFigure(g, e, assets.MyPen);
                DrawPanel.Image = assets.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        public void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            int len = Points.Count;
            g.DrawLine(myPen, Points[len - 1].X, Points[len - 1].Y, e.X, e.Y);
        }

        public override void SetFigure(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                LeftMouseUpClick(e, assets, DrawPanel);
            }
            if (((e.Button & MouseButtons.Right) != 0) && (Points.Count > 1))
            { 
                FinishPainting();
            }
        }

        public void LeftMouseUpClick(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            Graphics g = Graphics.FromImage(assets.MainCanvas);
            int len = Points.Count;
            DrawFigure(g, e, assets.MyPen);
            Points.Add(new Point(e.X, e.Y));
            DrawPanel.Image = assets.MainCanvas;
        }

        public override void FinishPainting()
        {
            Points.Clear();
        }

        public override void Redraw(Graphics g, Pen myPen)
        {
            g.Clear(Color.White);
            g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
            for (int i = 0; i < Points.Count - 1; i++)
            {
                g.DrawLine(myPen, Points[i], Points[i + 1]);
            }
        }

        public override void BreakDraw(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            FinishPainting();
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