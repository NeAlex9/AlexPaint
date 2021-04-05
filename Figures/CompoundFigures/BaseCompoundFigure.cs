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
    public abstract class BaseCompoundFigure : Figure
    {
        public override void PrepareForDrawing(Point clickedPoint, DrawingAssets assets)
        {
            if (assets.CurrentFigure.Points.Count < 1)
            {
                Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
                CanvasWithoutCurrentFigure = (Bitmap)assets.MainCanvas.Clone();
            }

        }

        public override void DrawWhileMouseMove(Graphics g, Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel)
        {
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
            Redraw(g);
            Points.RemoveAt(Points.Count - 1);
        }
    }
}
