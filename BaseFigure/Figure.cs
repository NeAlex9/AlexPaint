﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BaseFigure
{
    public class FigureData
    {
        public string FigureType { get; set; }

        public List<Point> Points { get; set; }

        public int IntColor { get; set; }

        public float Width { get; set; }

        public FigureData()
        {
            Points = new List<Point>();
        }
    }

    public abstract class Figure
    {
        public Bitmap CanvasWithoutCurrentFigure { set; get; }

        public bool HadTheFigureDrawn { set; get; }

        public Pen MyPen { set; get; }

        public Figure()
        {
            MyPen = new Pen(Color.Black, 1);
            MyPen.StartCap = LineCap.Round;
            MyPen.EndCap = LineCap.Round;
            CanvasWithoutCurrentFigure = new Bitmap(1920, 1080);
        }

        public abstract void PrepareForDrawing(Point clickedPoint, Bitmap MainCanvas);

        public abstract void DrawWhileMouseMove(Graphics g, Point clickedPoint);

        public virtual void RightMouseUpClick(Graphics g, Point clickedPoint) { }

        public abstract void LeftMouseUpClick(Graphics g, Point clickedPoint);

        public virtual void Redraw(Graphics g) { }

        public void Redraw(Graphics g, FigureData data)
        {
            SetPointsForRedrawning(data);
            Redraw(g);
        }

        public virtual void BreakDraw(Graphics g, Point clickedPoint) { }

        public abstract void FinishDrawning();

        public abstract void SetPointsForRedrawning(FigureData data);

        public abstract FigureData GetPointsForRedrawning();
    }
}