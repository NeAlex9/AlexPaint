using System;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polyline : BaseCompoundFigure
    {
        public override void RightMouseUpClick(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            FinishPainting();
        }

        public override void LeftMouseUpClick(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            Graphics g = Graphics.FromImage(assets.MainCanvas);
            int len = Points.Count;
            g.DrawLine(MyPen, Points[len - 1].X, Points[len - 1].Y, clickedPoint.X, clickedPoint.Y);
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
            DrawPanel.Image = assets.MainCanvas;
        }

        public override void Redraw(Graphics g)
        {
            g.Clear(Color.White);
            g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
            for (int i = 0; i < Points.Count - 1; i++)
            {
                g.DrawLine(MyPen, Points[i], Points[i + 1]);
            }
        }

        public override void BreakDraw(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            FinishPainting();
        }
    }
}