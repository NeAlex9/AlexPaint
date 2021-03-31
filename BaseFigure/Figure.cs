using System.Drawing;
using System.Windows.Forms;

namespace BaseFigure
{
    public abstract class Figure
    {
        public int xStart { get; set; }
        public int yStart { get; set; }
        
        private Pen myPen;
        public Figure()
        {
            
        }

        public abstract void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart);

        public abstract void OnMouseDownClick(int xClick, int yClick);

        public abstract void OnMouseUpClick(Graphics g, MouseEventArgs e, Pen myPen, int xClick, int yClick);
    }
}