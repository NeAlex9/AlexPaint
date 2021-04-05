using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFigure
{
    public class DrawingAssets
    {
        public Bitmap MainCanvas { get; set; }
        public Bitmap HelperCanvas { get; set; }
        public Figure CurrentFigure { set; get; }

        public DrawingAssets(List<Figure> AllFigures)
        {
            MainCanvas = new Bitmap(1920, 1080);
            HelperCanvas = new Bitmap(1920, 1080);
            CurrentFigure = AllFigures[0];
        }
    }
}
