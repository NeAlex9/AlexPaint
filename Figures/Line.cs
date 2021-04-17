using BaseFigure;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Line : Figure
    {
        private Point startPoint;

        private Point endPoint;

        public Line() { }

        private Line(Line source, Bitmap MainCanvas) : base(source, MainCanvas)
        {
            this.startPoint = source.startPoint;
            this.endPoint = source.endPoint;
        }

        public override void PrepareForDrawing(Point clickedPoint, Bitmap MainCanvas)
        {
            HadTheFigureDrawn = false;
            startPoint = new Point(clickedPoint.X, clickedPoint.Y);
            CanvasWithoutCurrentFigure = MainCanvas;
        }

        public override void DrawWhileMouseMove(Graphics g, Point clickedPoint)
        {
            endPoint = clickedPoint;
            DrawFigure(g);
        }

        public void DrawFigure(Graphics g)
        {
            g.DrawLine(MyPen, startPoint, endPoint);
        }

        public override void LeftMouseUpClick(Graphics g, Point clickedPoint)
        {
            endPoint = clickedPoint;
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

        public override Figure Clone(Bitmap MainCanvas)
        {
            return new Line(this, MainCanvas);
        }

        public override void FinishDrawning()
        {
            endPoint.X = -1;
            endPoint.Y = -1;
        }

        public override void SetPointsForRedrawning(FigureData data)
        {
            startPoint = data.Points[0];
            endPoint = data.Points[1];
            Color color = Color.FromArgb(data.IntColor);
            MyPen = new Pen(color, data.Width);
            MyPen.StartCap = LineCap.Round;
            MyPen.EndCap = LineCap.Round;
        }

        public override FigureData GetPointsForRedrawning()
        {
            var data = new FigureData();
            data.Points.Add(startPoint);
            data.Points.Add(endPoint);
            Color color = Color.FromArgb(data.IntColor);
            MyPen = new Pen(color, data.Width);
            data.Width = MyPen.Width;
            data.FigureType = this.GetType().ToString();
            return data;
        }
    }
}