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
        public Bitmap MainCanvas { get; set; }
        public Bitmap HelperCanvas { get; set; }

        public List<Figure> AllFigures { set; get; }

        public Paint()
        {
            myPen.StartCap = LineCap.Round;
            myPen.EndCap = LineCap.Round;
            MainCanvas = new Bitmap(1920, 1080);
            HelperCanvas = new Bitmap(1920, 1080);
            AllFigures = new List<Figure>();
            AllFigures.Add(new Line());
            AllFigures.Add(new Brush());
            AllFigures.Add(new Ellipse());
            AllFigures.Add(new Polygone());
            AllFigures.Add(new Polyline());
            AllFigures.Add(new Rectangle());
            AllFigures.Add(new Triangle());
            CurrentFigure = AllFigures[0];
        }

        public void SetFigureForDraw<T>()
        {
            for (int i = 0; i < AllFigures.Count; i++)
            {
                if (AllFigures[i] is T && !(CurrentFigure is T))
                {
                    CurrentFigure = AllFigures[i];
                }
            }
        }
                

    }
}