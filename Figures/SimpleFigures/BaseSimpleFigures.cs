using BaseFigure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexPaint
{
    public abstract class BaseSimpleFigures : Figure
    {
        protected int xStart;
        protected int yStart;

        public BaseSimpleFigures()
        {
            Points = new List<Point>();
        }

        public override void PrepareForDrawing(Point clickedPoint, DrawingAssets assets)
        {
            xStart = clickedPoint.X;
            yStart = clickedPoint.Y;
            CanvasWithoutCurrentFigure = (Bitmap)assets.MainCanvas.Clone();
        }

        public override void DrawWhileMouseMove(Graphics g, Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            Points.Clear();
            DrawFigure(g, clickedPoint, MyPen);
        }

        public abstract void DrawFigure(Graphics g, Point clickedPoint, Pen myPen);

        public override void RightMouseUpClick(Graphics g, Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {

        }

        public override void LeftMouseUpClick(Graphics g, Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            if (xStart > 0 && yStart > 0)
            {
                Points.Clear();
                DrawFigure(g, clickedPoint, MyPen);
                FinishPainting();
            }
        }

        public override void Redraw(Graphics g)
        {

        }
    }
}
