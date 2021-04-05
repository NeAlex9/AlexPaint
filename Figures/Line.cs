using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Line : Figure
    {
        public override void PrepareForDrawing(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets)
        {
            if ((MouseButtons.Left & clickedButton) != 0)
            {
                Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
                CanvasWithoutCurrentFigure = (Bitmap)assets.MainCanvas.Clone();
            }
        }

        public override void DrawWhileMouseMove(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & clickedButton) != 0 && Points.Count > 0)
            {
                Graphics g = Graphics.FromImage(assets.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(assets.MainCanvas, 0, 0);
                DrawFigure(g, clickedPoint, MyPen);
                DrawPanel.Image = assets.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        public void DrawFigure(Graphics g, Point clickedPoint, Pen myPen)
        {
            int len = Points.Count;
            g.DrawLine(myPen, Points[len - 1].X, Points[len - 1].Y, clickedPoint.X, clickedPoint.Y);
        }

        public override void SetFigure(Point clickedPoint, MouseButtons clickedButton, DrawingAssets assets, PictureBox DrawPanel)
        {
            if ((MouseButtons.Left & clickedButton) != 0 && Points.Count > 0)
            {
                Graphics g = Graphics.FromImage(assets.MainCanvas);
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