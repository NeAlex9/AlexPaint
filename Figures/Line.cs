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

        public override void DrawWhileMouseMove(Graphics g, Point clickedPoint, DrawingAssets assets)
        {
            if (Points.Count > 0)
            {
                DrawFigure(g, clickedPoint);
            }
        }

        public void DrawFigure(Graphics g, Point clickedPoint)
        {
            int len = Points.Count;
            g.DrawLine(MyPen, Points[len - 1].X, Points[len - 1].Y, clickedPoint.X, clickedPoint.Y);
        }

        public override void LeftMouseUpClick(Graphics g, Point clickedPoint, DrawingAssets assets)
        {
            if (Points.Count > 0)
            {
                DrawFigure(g, clickedPoint);
                FinishPainting();
            }
        }

        public override void RightMouseUpClick(Graphics g, Point clickedPoint, DrawingAssets assets)
        {

        }

        public override void Redraw(Graphics g)
        {

        }
    }
}