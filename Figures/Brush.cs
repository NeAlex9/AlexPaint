using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Brush : Figure
    {

        public override void PrepareForDrawing(MouseEventArgs e, DrawingAssets assets)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Points.Add(new Point(e.X, e.Y));
                Points.Add(new Point(e.X + 1, e.Y));
            }
        }

        public void DrawFigure(Graphics g, Pen myPen)
        {
            int len = Points.Count;
            g.DrawLine(myPen, Points[len - 2], Points[len - 1]);
        }

        public override void DrawWhileMouseMove(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Points.Add(new Point(e.X, e.Y));
                Graphics g = Graphics.FromImage(assets.MainCanvas);
                DrawFigure(g, assets.MyPen);
                DrawPanel.Image = assets.MainCanvas;
                DrawPanel.Refresh();
            }
        }

        public override void SetFigure(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                DrawWhileMouseMove(e, assets, DrawPanel);
                FinishPainting();
            }
        }

        public override void FinishPainting()
        {
            Points.Clear();
        }
    }
}