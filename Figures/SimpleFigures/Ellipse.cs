using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Ellipse : BaseSimpleFigures
    {
        private Ellipse(Ellipse source, Bitmap MainCanvas) : base(source, MainCanvas)
        {
            this.startPoint = source.startPoint;
            this.endPoint = source.endPoint;
        }

        public Ellipse() { }

        public override void DrawFigure(Graphics g)
        {
            if (startPoint.X <= endPoint.X && startPoint.Y <= endPoint.Y)
            {
                g.DrawEllipse(MyPen, startPoint.X, startPoint.Y, endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
            }
            else if (startPoint.X > endPoint.X && startPoint.Y <= endPoint.Y)
            {
                g.DrawEllipse(MyPen, endPoint.X, startPoint.Y, startPoint.X - endPoint.X, endPoint.Y - startPoint.Y);
            }
            else if ((startPoint.X <= endPoint.X && startPoint.Y > endPoint.Y))
            {
                g.DrawEllipse(MyPen, startPoint.X, endPoint.Y, endPoint.X - startPoint.X, startPoint.Y - endPoint.Y);
            }
            else if (startPoint.X > endPoint.X && startPoint.Y > endPoint.Y)
            {
                g.DrawEllipse(MyPen, endPoint.X, endPoint.Y, startPoint.X - endPoint.X, startPoint.Y - endPoint.Y);
            }
        }

        public override Figure Clone(Bitmap MainCanvas)
        {
            return new Ellipse(this, MainCanvas);
        }
    }
}