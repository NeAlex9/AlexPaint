using BaseFigure;
using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace AlexPaint
{
    public class Rectangle : BaseSimpleFigures
    {
        private Rectangle(Rectangle source, Bitmap MainCanvas) : base(source, MainCanvas)
        {
            this.startPoint = source.startPoint;
            this.endPoint = source.endPoint;
        }

        public Rectangle() { }        

        public override void DrawFigure(Graphics g)
        {
            List<Point> temp = new List<Point>();
            temp.Add(new Point(startPoint.X, startPoint.Y));
            temp.Add(new Point(endPoint.X, startPoint.Y));
            temp.Add(new Point(endPoint.X, endPoint.Y));
            temp.Add(new Point(startPoint.X, endPoint.Y));
            g.DrawPolygon(MyPen, temp.ToArray());
        }

        public override Figure Clone(Bitmap MainCanvas)
        {
            return new Rectangle(this, MainCanvas);
        }
    }
}