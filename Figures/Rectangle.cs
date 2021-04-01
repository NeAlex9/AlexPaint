using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Rectangle : Figure 
    {
        public Rectangle()
        {

        }
        
        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
            /*Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            System.Drawing.Rectangle myRec = new System.Drawing.Rectangle(50, 10, 60, 100);
            g.DrawRectangle(myPen, myRec);*/
        }
        
        public override void OnMouseDownClick(int xClick, int yClick, Bitmap originalCanvas)
        {
            
        }
        
        public override void OnMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick)
        {
            
        }
    }
}