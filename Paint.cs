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
        public Bitmap MainCanvas { get; set; }
        public Bitmap HelperCanvas { get; set; }
        public Figure CurrentFigure { set; get; }

        public List<Figure> AllFigures { set; get; }

        public History MyHistory { set; get; }

        public Paint()
        {
            AllFigures = new List<Figure>();
            AllFigures.Add(new Line());
            AllFigures.Add(new Ellipse());
            AllFigures.Add(new Polygone());
            AllFigures.Add(new Polyline());
            AllFigures.Add(new Rectangle());
            AllFigures.Add(new Triangle());
            MainCanvas = new Bitmap(1920, 1080);
            HelperCanvas = new Bitmap(1920, 1080);
            CurrentFigure = AllFigures[0];
            MyHistory = new History();
        }

        public void SetFigureForDraw<T>()
        {
            for (int i = 0; i < AllFigures.Count; i++)
            {
                if (AllFigures[i] is T && !(CurrentFigure is T))
                {
                    CurrentFigure = AllFigures[i];
                    return;
                }
            }
        }
    }
}