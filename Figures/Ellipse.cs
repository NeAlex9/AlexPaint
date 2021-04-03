using System.Collections.Generic;
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

        public override void PrepareForDrawing(MouseEventArgs e, DrawingAssets assets)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                Points.Add(new Point(e.X, e.Y));
            }
        }

        public override void DrawWhileMouseMove(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                Graphics g = Graphics.FromImage(assets.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(assets.MainCanvas, 0, 0);
                DrawFigure(g, e, assets.MyPen);
                DrawPanel.Image = assets.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        public void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            int len = Points.Count;
            int xPrev = Points[len - 1].X;
            int yPrev = Points[len - 1].Y;
            if (xPrev <= e.X && yPrev <= e.Y)
            {
                g.DrawEllipse(myPen, xPrev, yPrev, e.X - xPrev, e.Y - yPrev);
            }
            else if (xPrev > e.X && yPrev <= e.Y)
            {
                g.DrawEllipse(myPen, e.X, yPrev, xPrev - e.X, e.Y - yPrev);
            }
            else if ((xPrev <= e.X && yPrev > e.Y))
            {
                g.DrawEllipse(myPen, xPrev, e.Y, e.X - xPrev, yPrev - e.Y);
            }
            else if (xPrev > e.X && yPrev > e.Y)
            {
                g.DrawEllipse(myPen, e.X, e.Y, xPrev - e.X, yPrev - e.Y);
            }
        }

        public override void SetFigure(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                Graphics g = Graphics.FromImage(assets.MainCanvas);
                DrawFigure(g, e, assets.MyPen);
                DrawPanel.Image = assets.MainCanvas;
                FinishPainting(); 
            }
        }


        public override void FinishPainting()
        {
            Points.Clear();
        }
    }
}