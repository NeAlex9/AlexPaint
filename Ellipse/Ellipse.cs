using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace Ellipse
{
    public class Ellipse : Figure
    {
        public Ellipse(Color color, int width) : base(color, width)
        {
        }

        public override void Draw(PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Rectangle myRec = new Rectangle(100, 250, 60, 80);
            g.DrawEllipse(myPen, myRec);*/
        }
        
        public override void Clear(PaintEventArgs e)
        {
            
        }
    }
}