using BaseFigure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllFigures
{
    public abstract class BaseCompoundFigure : Figure
    {
        public List<Point> Points { get; set; }

        protected BaseCompoundFigure()
        {
            Points = new List<Point>();
        }

        public override void PrepareForDrawing(Point clickedPoint, Bitmap MainCanvas)
        {
            if (Points.Count < 1)
            {
                HadTheFigureDrawn = false;
                Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
                CanvasWithoutCurrentFigure = (Bitmap)MainCanvas.Clone();     ///!!!!!!!!!!!!!
            }

        }

        public override void DrawWhileMouseMove(Graphics g, Point clickedPoint)
        {
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
            g.Clear(Color.White);
            g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
            Redraw(g);
            Points.RemoveAt(Points.Count - 1);
        }

        public override void FinishDrawning()
        {
            Points.Clear();
        }

        public override void SetPointsForRedrawning(FigureData data)
        {
            this.Points = new List<Point>(data.Points);
            Color color = Color.FromArgb(data.IntColor);
            MyPen = new Pen(color, data.Width);
            MyPen.StartCap = LineCap.Round;
            MyPen.EndCap = LineCap.Round;
        }

        public override FigureData GetPointsForRedrawning()
        {
            var data = new FigureData();
            data.Points = new List<Point>(this.Points);
            data.IntColor = MyPen.Color.ToArgb();
            data.Width = MyPen.Width;
            data.FigureType = this.GetType().ToString();
            return data;
        }
    }
}
