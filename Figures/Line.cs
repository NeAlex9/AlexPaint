using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Line : Figure
    {
        public override void PrepareForDrawing(Point clickedPoint, DrawingAssets assets)
        {
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
            CanvasWithoutCurrentFigure = (Bitmap)assets.MainCanvas.Clone();
        }

        public override void DrawWhileMouseMove(Graphics g, Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            if (Points.Count > 0)
            {
                DrawFigure(g, clickedPoint, MyPen);
            }
        }

        public void DrawFigure(Graphics g, Point clickedPoint, Pen myPen)
        {
            int len = Points.Count;
            g.DrawLine(myPen, Points[len - 1].X, Points[len - 1].Y, clickedPoint.X, clickedPoint.Y);
        }

        public override void LeftMouseUpClick(Graphics g, Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            if (Points.Count > 0)
            {
                DrawFigure(g, clickedPoint, MyPen);
                FinishPainting();
            }
        }

        public override void RightMouseUpClick(Graphics g, Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {

        }

        public override void Redraw(Graphics g)
        {

        }
    }
}