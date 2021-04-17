﻿using BaseFigure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexPaint
{
    public abstract class BaseCompoundFigure : Figure
    {
        public List<Point> Points { get; set; }

        protected BaseCompoundFigure(Figure source, Bitmap MainCanvas) : base(source, MainCanvas) { }

        protected BaseCompoundFigure()
        {
            Points = new List<Point>();
        }

        public override void PrepareForDrawing(Point clickedPoint, Bitmap MainCanvas)
        {
            if (Points.Count < 1)
            {
                HadTheFigureDrawn = false;
                Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
                CanvasWithoutCurrentFigure = (Bitmap)MainCanvas.Clone();     ///!!!!!!!!!!!!!
            }

        }

        public override void DrawWhileMouseMove(Graphics g, Point clickedPoint)
        {
            Points.Add(new Point(clickedPoint.X, clickedPoint.Y));
            g.Clear(Color.White);
            g.DrawImage(CanvasWithoutCurrentFigure, 0, 0);
            Redraw(g);
            Points.RemoveAt(Points.Count - 1);
        }

        public override void FinishDrawning()
        {
            Points.Clear();
        }

        public override void SetPointsForRedrawning(FigureData data)
        {
            this.Points = new List<Point>(data.Points);
            MyPen = new Pen(data.Color, data.Width);
            MyPen.StartCap = LineCap.Round;
            MyPen.EndCap = LineCap.Round;
        }

        public override FigureData GetPointsForRedrawning()
        {
            var data = new FigureData();
            data.Points = new List<Point>(this.Points);
            data.Color = MyPen.Color;
            data.Width = MyPen.Width;
            data.FigureType = this.GetType().ToString();
            return data;
        }
    }
}
