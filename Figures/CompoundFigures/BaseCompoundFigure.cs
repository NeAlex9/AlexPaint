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
    public abstract class BaseCompoundFigure : Figure
    {
        public List<Point> Points { get; set; }

        protected BaseCompoundFigure(Figure source, Bitmap MainCanvas) : base(source, MainCanvas) { }

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
            Redraw(g);
            Points.RemoveAt(Points.Count - 1);
        }

        public override void FinishDrawning()
        {
            Points.Clear();
        }
    }
}
