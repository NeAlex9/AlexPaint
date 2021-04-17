using System;
using System.Collections.Generic;
using System.Drawing;
using BaseFigure;

namespace AllFigures

{
    public class Polyline : BaseCompoundFigure
    {
        public Polyline() : base() { }

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
    }
}