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

        public abstract void DrawFigure(Graphics g, MouseEventArgs e, Pen myPen);

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
