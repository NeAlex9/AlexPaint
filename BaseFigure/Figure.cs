using System.Drawing;
using System.Windows.Forms;

namespace BaseFigure
{
    public abstract class Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }
        public Figure(Color color, int width)
        {
            this.Color = color;
            this.Width = width;
        } 
        public abstract void Draw(PaintEventArgs e);
        public abstract void Clear(PaintEventArgs e);
    }
}