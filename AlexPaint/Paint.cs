using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using BaseFigure;
using AllFigures;
using Plugin;

namespace AlexPaint
{
    public class Paint
    {
        public Bitmap MainCanvas { get; set; }
        public Bitmap HelperCanvas { get; set; }
        public Figure CurrentFigureDrawner { set; get; }

        public List<Figure> AllFiguresDrawner { set; get; }

        public History MyHistory { set; get; }

        public Paint()
        {
            AllFiguresDrawner = new List<Figure>();
            AllFiguresDrawner.Add(new Line());
            AllFiguresDrawner.Add(new Ellipse());
            AllFiguresDrawner.Add(new Polygone());
            AllFiguresDrawner.Add(new Polyline());
            AllFiguresDrawner.Add(new AllFigures.Rectangle());
            AllFiguresDrawner.Add(new Triangle());
            AllFiguresDrawner.Add(new Trapezoid());
            MainCanvas = new Bitmap(1920, 1080);
            HelperCanvas = new Bitmap(1920, 1080);
            CurrentFigureDrawner = AllFiguresDrawner[0];
            MyHistory = new History();
        }

        public void SetFigureForDraw<T>()
        {
            for (int i = 0; i < AllFiguresDrawner.Count; i++)
            {
                if (AllFiguresDrawner[i] is T && !(CurrentFigureDrawner is T))
                {
                    CurrentFigureDrawner = AllFiguresDrawner[i];
                    return;
                }
            }
        }
    }
}