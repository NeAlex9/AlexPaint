﻿using System.Drawing;
using System.Windows.Forms;

namespace BaseFigure
{
    public abstract class Figure
    {
        public Bitmap CanvasWithOriginalFigure { get; set; }

        public int xStart { get; set; }
        public int yStart { get; set; }
        
        private Pen myPen;
        public Figure()
        {
            CanvasWithOriginalFigure = new Bitmap(1920, 1080);
        }

        public abstract void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart);

        public abstract void OnMouseDownClick(int xClick, int yClick, Bitmap originalCanvas);

        public abstract void OnMouseUpClick(Graphics g, Graphics g1, MouseEventArgs e, Pen myPen, int xPrevClick, int yPrevClick);
    }
}