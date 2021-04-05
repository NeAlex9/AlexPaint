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
        public DrawingAssets MyDrawingAssets { get; set; }

        public List<Figure> AllFigures { set; get; }

        public Paint()
        {
            AllFigures = new List<Figure>();
            AllFigures.Add(new Line());
            AllFigures.Add(new Ellipse());
            AllFigures.Add(new Polygone());
            AllFigures.Add(new Polyline());
            AllFigures.Add(new Rectangle());
            AllFigures.Add(new Triangle());
            MyDrawingAssets = new DrawingAssets(AllFigures);
        }

        public void SetFigureForDraw<T>()
        {
            for (int i = 0; i < AllFigures.Count; i++)
            {
                if (AllFigures[i] is T && !(MyDrawingAssets.CurrentFigure is T))
                {
                    MyDrawingAssets.CurrentFigure = AllFigures[i];
                    return;
                }
            }
        }
    }
}