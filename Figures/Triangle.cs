using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Triangle : Figure
    {
        public Triangle()
        {
        }
        
        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
        }
        
        public override void OnMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        { 

        }
        
        public override void OnMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
        {
            
        }
    }
}