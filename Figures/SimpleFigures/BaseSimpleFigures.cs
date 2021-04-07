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
        protected Point startPoint;
        protected Point endPoint;

        protected BaseSimpleFigures(Figure source, Bitmap MainCanvas) : base(source, MainCanvas) { }

        public BaseSimpleFigures() { }

        public override void PrepareForDrawing(Point clickedPoint, Bitmap MainCanvas)
        {
            HadTheFigureDrawn = false;
            startPoint = clickedPoint;
            endPoint.X = -1;
            endPoint.Y = -1;
            CanvasWithoutCurrentFigure = MainCanvas;
        }

        public override void DrawWhileMouseMove(Graphics g, Point clickedPoint)
        {
            endPoint.X = clickedPoint.X;
            endPoint.Y = clickedPoint.Y;
            DrawFigure(g);
        }

        public abstract void DrawFigure(Graphics g);

        public override void LeftMouseUpClick(Graphics g, Point clickedPoint)
        {
            if ((startPoint.X == endPoint.X && startPoint.Y == endPoint.Y) || endPoint.X < 0 || endPoint.Y < 0)
            {
                return;
            }

            DrawFigure(g);
            HadTheFigureDrawn = true;

        }

        public override void Redraw(Graphics g)
        {
            if ((startPoint.X == endPoint.X && startPoint.Y == endPoint.Y) || endPoint.X < 0 || endPoint.Y < 0)
            {
                return;
            }

            DrawFigure(g);

        }

        public override void FinishDrawning()
        {
            endPoint.X = -1;
            endPoint.Y = -1;
        }
    }
}
