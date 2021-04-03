using BaseFigure;
using System.Drawing;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Line : Figure
    {
        public Line()
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
            g.DrawLine(myPen, Points[len - 1].X, Points[len - 1].Y, e.X, e.Y);
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

        public override void Redraw(Graphics g, Pen myPen)
        {

        }

        public override void BreakDraw(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {
            
        }
    }
}