using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Brush : Figure
    {

        public override void PrepareForDrawing(MouseEventArgs e, DrawingAssets assets)
        {

        }

        public override void DrawWhileMouseMove(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {

        }

        public override void SetFigure(MouseEventArgs e, DrawingAssets assets, PictureBox DrawPanel)
        {

        }

        public override void FinishPainting()
        {
            Points.Clear();
        }
    }
}