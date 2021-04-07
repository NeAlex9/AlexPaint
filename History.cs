using BaseFigure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexPaint
{
    public class History
    {
        public History()
        {
            allDrawnFigures = new List<Figure>();
        }

        private int pointer = 0;

        public int Pointer
        {
            set
            {

                if (value > allDrawnFigures.Count || value < 0)
                {
                    return;
                }

                pointer = value;
            }

            get
            {
                return pointer;
            }
        }

        private List<Figure> allDrawnFigures = new List<Figure>();

        public void AddToAllDrawnFigures(Figure figure)
        {
            if (allDrawnFigures.Count != pointer)
            {
                Reset();
            }

            allDrawnFigures.Add(figure);
        }

        public void DrawFigures(Graphics g)
        {
            g.Clear(Color.White);
            for (int i = 0; i < Pointer; i++)
            {
                allDrawnFigures[i].Redraw(g);
            }
        }

        private void Reset()
        {
            int count = allDrawnFigures.Count - pointer;
            allDrawnFigures.RemoveRange(pointer, count);
            pointer = allDrawnFigures.Count;
        }
    }
}
