using BaseFigure;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Triangle : Figure
    {

        private int xStart;
        private int yStart;

        public Triangle()
        {
            Points = new List<Point>();
        }

        public override void PrepareForDrawing(MouseEventArgs e, DrawingAssets assets)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                xStart = e.X;
                yStart = e.Y;
            }
        }

        public override void DrawWhileMouseMove(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                Graphics g = Graphics.FromImage(assets.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(assets.MainCanvas, 0, 0);
                Points.Clear();
                DrawFigure(g, e, assets.MyPen);
                DrawPanel.Image = assets.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        public void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen)
        {
            if (yStart <= e.Y)
            {
                Points.Add(new Point(xStart, e.Y));
                Points.Add(new Point(e.X, e.Y));
                if (xStart <= e.X)
                {
                    Points.Add(new Point((e.X - xStart) / 2 + xStart, yStart));
                }
                else
                {
                    Points.Add(new Point((xStart - e.X) / 2 + e.X, yStart));
                }
                g.DrawPolygon(myPen, Points.ToArray());
            }
            else
            {
                Points.Add(new Point(xStart, yStart));
                Points.Add(new Point(e.X, yStart));
                if (xStart <= e.X)
                {
                    Points.Add(new Point((e.X - xStart) / 2 + xStart, e.Y));
                }
                else
                {
                    Points.Add(new Point((xStart - e.X) / 2 + e.X, e.Y));
                }
                g.DrawPolygon(myPen, Points.ToArray());
            }

        }

        public override void SetFigure(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                Graphics g = Graphics.FromImage(assets.MainCanvas);
                Points.Clear();
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