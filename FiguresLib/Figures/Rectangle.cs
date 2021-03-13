using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace Rectangle
{
    public class Rectangle : Figure 
    {
        public Rectangle(Color color, int width) : base(color, width)
        {
        }
        
        public override void Draw(PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            System.Drawing.Rectangle myRec = new System.Drawing.Rectangle(50, 10, 60, 100);
            g.DrawRectangle(myPen, myRec);*/
        }
        
        public override void Clear(PaintEventArgs e)
        {
            
        }
    }
}