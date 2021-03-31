using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Paint
    {

        private Pen myPen = new Pen(Color.Black, 1);

        public Pen MyPen
        {
            get => myPen;
            set => myPen = value;
        }

        public Figure CurrentFigure { set; get; }
        public Bitmap MainCanvas  { get; set; }
        public Bitmap HelperCanvas { get; set; }
        
        private List<Figure> allFigures = new List<Figure>();

        public Paint()
        {
            myPen.StartCap = LineCap.Round;
            myPen.EndCap = LineCap.Round;
            MainCanvas = new Bitmap(1920, 1080);
            HelperCanvas = new Bitmap(1920, 1080);
        }
        
    }
}