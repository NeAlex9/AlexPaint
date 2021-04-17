using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polyline : BaseCompoundFigure
    {
        public Polyline() : base() { }

        protected Polyline(Polyline source, Bitmap MainCanvas) : base(source, MainCanvas)
        {
            List<Point> temp = new List<Point>();
            for (int i = 0; i < source.Points.Count; i++)
            {
                temp.Add(source.Points[i]);
            }
            this.Points = temp;
        }

        public override void RightMouseUpClick(Graphics g, Point clickedPoint)
        {
            if (Points.Count > 0)
            {
                HadTheFigureDrawn = true;
            }
        }

        public override void LeftMouseUpClick(Graphics g, Point clickedPoint)
        {
            int len = Points.Count;
            g.DrawLine(MyPen, Points[len - 1].X, Points[len - 1].Y, clickedPoint.X, clickedPoint.Y);
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
        }

        public override void Redraw(Graphics g)
        {

            for (int i = 0; i < Points.Count - 1; i++)
            {
                g.DrawLine(MyPen, Points[i], Points[i + 1]);
            }
        }

        public override void BreakDraw(Graphics g, Point clickedPoint)
        {
            if (Points.Count > 0)
            {
                HadTheFigureDrawn = true;
            }
        }

        public override Figure Clone(Bitmap MainCanvas)
        {
            return new Polyline(this, MainCanvas);
        }
    }
}