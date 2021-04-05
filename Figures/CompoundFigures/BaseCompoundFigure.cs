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
        public override void PrepareForDrawing(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets)
        {
            if ((clickedButton & MouseButtons.Left) != 0)
            {
                if (assets.CurrentFigure.Points.Count < 1)
                {
                    Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
                    CanvasWithoutCurrentFigure = (Bitmap)assets.MainCanvas.Clone();
                }
            }
        }

        public override void SetFigure(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((clickedButton & MouseButtons.Left) != 0 && Points.Count > 0)
            {
                LeftMouseUpClick(clickedPoint, assets, DrawPanel);
            }
            if ((clickedButton & MouseButtons.Right) != 0 && Points.Count > 1)
            {
                RightMouseUpClick(clickedPoint, assets, DrawPanel);
            }
        }

        public override void DrawWhileMouseMove(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((clickedButton & MouseButtons.Left) != 0 && Points.Count > 0)
            {
                Graphics g = Graphics.FromImage(assets.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
                Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
                Redraw(g);
                Points.RemoveAt(Points.Count - 1);
                DrawPanel.Image = assets.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        public abstract void LeftMouseUpClick(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel);

        public abstract void RightMouseUpClick(Point clickedPoint, DrawingAssets assets, PictureBox DrawPanel);
    }
}
