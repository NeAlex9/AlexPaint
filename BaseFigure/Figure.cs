using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BaseFigure
{
    public abstract class Figure
    {

        public List<Point> Points { get; set; }

        private Pen myPen;
        public Figure()
        {
            Points = new List<Point>();
        }

        public abstract void PrepareForDrawing(MouseEventArgs e, DrawingAssets assets);

        public abstract void DrawWhileMouseMove(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel);

        public abstract void SetFigure(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel);

        public abstract void FinishPainting();

        public abstract void Redraw(Graphics g, Pen myPen);

        public abstract void BreakDraw(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel);
    }
}