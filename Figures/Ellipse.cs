using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Ellipse : Figure
    {
        public Ellipse()
        {
        }

        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
            /*Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Rectangle myRec = new Rectangle(100, 250, 60, 80);
            g.DrawEllipse(myPen, myRec);*/
        }
        
        public override void OnMouseDownClick(int xClick, int yClick)
        {
            
        }
        
        public override void OnMouseUpClick(Graphics g, MouseEventArgs e, Pen myPen, int xClick, int yClick)
        {
            
        }
    }
}