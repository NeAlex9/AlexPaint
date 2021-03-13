using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace Triangle
{
    public class Triangle : Figure
    {
        public Triangle(Color color, int width) : base(color, width)
        {
        }
        
        public override void Draw(PaintEventArgs e)
        {
        }
        
        public override void Clear(PaintEventArgs e)
        {
            
        }
    }
}