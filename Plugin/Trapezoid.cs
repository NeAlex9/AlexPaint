using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AllFigures;

namespace Plugin
{
    public class Trapezoid : BaseSimpleFigures
    {
        public override void DrawFigure(Graphics g)
        {

            int fraction = Math.Abs(endPoint.X - startPoint.X) / 3;
            Point ThirdPoint;
            Point FourthPoint;
            if (startPoint.X <= endPoint.X && startPoint.Y <= endPoint.Y)
            {
                ThirdPoint = new Point(startPoint.X + 2 * fraction, startPoint.Y);
                FourthPoint = new Point(startPoint.X - fraction, endPoint.Y);
            }
            else if (startPoint.X > endPoint.X && startPoint.Y < endPoint.Y)
            {
                ThirdPoint = new Point(startPoint.X - fraction * 2, startPoint.Y);
                FourthPoint = new Point(startPoint.X + fraction, endPoint.Y);
            }
            else if (startPoint.X < endPoint.X && startPoint.Y > endPoint.Y)
            {
                ThirdPoint = new Point(startPoint.X + 4 * fraction, startPoint.Y);
                FourthPoint = new Point(startPoint.X + fraction, endPoint.Y);
            }
            else
            {
                ThirdPoint = new Point(startPoint.X - 4 * fraction, startPoint.Y);
                FourthPoint = new Point(startPoint.X - fraction, endPoint.Y);
            }
            g.DrawPolygon(MyPen, new Point[] { startPoint, ThirdPoint, endPoint, FourthPoint });
        }
    }

    public class CustomButton : Button
    {
        private AlexPaint.Paint myPaint;

        public CustomButton(AlexPaint.Paint myPaint, Size buttonSize, Point locationPoint)
        {
            this.myPaint = myPaint;
            Location = locationPoint;
            Size = buttonSize;
            FlatStyle = FlatStyle.Flat;
            BackgroundImageLayout = ImageLayout.Stretch;
            Image im = Properties.Resource1.trapeze;
            BackgroundImage = im;
            MouseClick += new MouseEventHandler(buttonTrapezoid_MouseClick);

        }

        private void buttonTrapezoid_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.CurrentFigureDrawner.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw(typeof(Trapezoid));
        }
    }
}
