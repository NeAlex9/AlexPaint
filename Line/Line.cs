using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace Line
{
    public class Line : Figure
    {
        public Line(Color color, int width) : base(color, width)
        {
        }
        
        public override void Draw(PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            g.DrawLine(myPen, 500, 100, 600, 30);*/
        }
        
        public override void Clear(PaintEventArgs e)
        {
            
        }
    }
}