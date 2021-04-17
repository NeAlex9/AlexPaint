using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BaseFigure
{
    public class FigureData
    {
        public string FigureType { get; set; }

        public List<Point> Points { get; set; }

        public int IntColor { get; set; }

        public float Width { get; set; }

        public FigureData()
        {
            Points = new List<Point>();
        }
    }

    public abstract class Figure
    {
        public Bitmap CanvasWithoutCurrentFigure { set; get; }

        public bool HadTheFigureDrawn { set; get; }

        public Pen MyPen { set; get; }

        public Figure()
        {
            MyPen = new Pen(Color.Black, 1);
            MyPen.StartCap = LineCap.Round;
            MyPen.EndCap = LineCap.Round;
        }

        protected Figure(Figure source, Bitmap MainCanvas)
        {
            this.CanvasWithoutCurrentFigure = (Bitmap)MainCanvas.Clone();
            this.MyPen = new Pen(source.MyPen.Color, source.MyPen.Width);
            this.HadTheFigureDrawn = source.HadTheFigureDrawn;
        }

        public abstract void PrepareForDrawing(Point clickedPoint, Bitmap MainCanvas);

        public abstract void DrawWhileMouseMove(Graphics g, Point clickedPoint);

        public virtual void RightMouseUpClick(Graphics g, Point clickedPoint) { }

        public abstract void LeftMouseUpClick(Graphics g, Point clickedPoint);

        public virtual void Redraw(Graphics g) { }

        public void Redraw(Graphics g, FigureData data)
        {
            SetPointsForRedrawning(data);
            Redraw(g);
        }

        public virtual void BreakDraw(Graphics g, Point clickedPoint) { }

        public abstract Figure Clone(Bitmap MainCanvas);

        public abstract void FinishDrawning();

        public abstract void SetPointsForRedrawning(FigureData data);

        public abstract FigureData GetPointsForRedrawning();
    }
}