using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BaseFigure
{
    public abstract class Figure
    {
        public Bitmap CanvasWithoutCurrentFigure { set; get; }

        public Pen MyPen { set; get; }

        public List<Point> Points { get; set; }

        public Figure()
        {
            MyPen = new Pen(Color.Black, 1);
            MyPen.StartCap = LineCap.Round;
            MyPen.EndCap = LineCap.Round;
            Points = new List<Point>();
        }

        public abstract void PrepareForDrawing(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets);

        public abstract void DrawWhileMouseMove(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets, PictureBox DrawPanel);

        public abstract void SetFigure(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets, PictureBox DrawPanel);

        public void FinishPainting()
        {
            Points.Clear();
        }

        public abstract void Redraw(Graphics g);

        public virtual void BreakDraw(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {

        }
    }
}