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
            AllDrawnFigures = new List<Figure>();
        }

        private int pointer = 0;

        public int Pointer 
        {
            set 
            {
                if (value > AllDrawnFigures.Count || value < 0)
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

        public List<Figure> AllDrawnFigures { set; get; }

        public void DrawFigures(Graphics g)
        {
            g.Clear(Color.White);
            for (int i = 0; i < Pointer; i++)
            {
                AllDrawnFigures[i].Redraw(g);
            }
        }
    }
}
