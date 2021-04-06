using System;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polyline : BaseCompoundFigure
    {
        public override void RightMouseUpClick(Graphics g, Point clickedPoint, DrawingAssets assets)
        {
            FinishPainting();
        }

        public override void LeftMouseUpClick(Graphics g, Point clickedPoint, DrawingAssets assets)
        {

            int len = Points.Count;
            g.DrawLine(MyPen, Points[len - 1].X, Points[len - 1].Y, clickedPoint.X, clickedPoint.Y);
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));

        }

        public override void Redraw(Graphics g)
        {
            if (Points.Count > 0)
            {
                g.Clear(Color.White);
                g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    g.DrawLine(MyPen, Points[i], Points[i + 1]);
                }
            }
        }

        public override void BreakDraw(Graphics g, Point clickedPoint, DrawingAssets assets)
        {
            FinishPainting();
        }
    }
}