using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polyline : Figure
    {
        public Polyline()
        {
        }

        public override void PrepareForDrawing(MouseEventArgs e, DrawingAssets assets)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                if (assets.CurrentFigure.Points.Count < 1)
                {
                    Points.Add(new Point(e.X, e.Y));
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
    }
}