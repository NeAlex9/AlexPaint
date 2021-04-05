using BaseFigure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexPaint
{
    public abstract class BaseSimpleFigures : Figure
    {
        protected int xStart;
        protected int yStart;

        public BaseSimpleFigures()
        {
            Points = new List<Point>();
        }

        public override void PrepareForDrawing(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets)
        {
            if ((MouseButtons.Left & clickedButton) != 0)
            {
                xStart = clickedPoint.X;
                yStart = clickedPoint.Y;
                CanvasWithoutCurrentFigure = (Bitmap)assets.MainCanvas.Clone();
            }
        }

        public override void DrawWhileMouseMove(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets, PictureBox DrawPanel)
        {
            if (MouseButtons.Left == clickedButton && xStart > 0 && yStart > 0)
            {
                Graphics g = Graphics.FromImage(assets.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(assets.MainCanvas, 0, 0);
                Points.Clear();
                DrawFigure(g, clickedPoint, MyPen);
                DrawPanel.Image = assets.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        public abstract void DrawFigure(Graphics g, Point clickedPoint, Pen myPen);

        public override void SetFigure(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & clickedButton) != 0 && xStart > 0 && yStart > 0)
            {
                Graphics g = Graphics.FromImage(assets.MainCanvas);
                Points.Clear();
                DrawFigure(g, clickedPoint, MyPen);
                DrawPanel.Image = assets.MainCanvas;
                FinishPainting();
            }
        }

        public override void Redraw(Graphics g)
        {

        }
    }
}
