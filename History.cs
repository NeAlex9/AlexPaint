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
            FiguresData = new List<FigureData>();
        }

        private int pointer = 0;

        public int Pointer
        {
            set
            {

                if (value > FiguresData.Count || value < 0)
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

        public List<FigureData> FiguresData = new List<FigureData>();

        public void AddToAllDrawnFigures(FigureData data)
        {
            if (FiguresData.Count != pointer)
            {
                Reset();
            }

            FiguresData.Add(data);
        }

        public void DrawFigures(Graphics g, List<Figure> allFigureDrawner)
        {
            g.Clear(Color.White);
            for (int i = 0; i < Pointer; i++)      
            {
                for (int j = 0; j < allFigureDrawner.Count; j++)
                {
                    if (FiguresData[i].FigureType == allFigureDrawner[j].GetType().ToString())
                    {
                        allFigureDrawner[j].Redraw(g, FiguresData[i]);
                        allFigureDrawner[j].FinishDrawning();
                        break;
                    }
                }
            }
        }

        private void Reset()
        {
            int count = FiguresData.Count - pointer;
            FiguresData.RemoveRange(pointer, count);
            pointer = FiguresData.Count;
        }
    }
}
