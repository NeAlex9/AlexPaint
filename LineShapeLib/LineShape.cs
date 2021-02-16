using System;
using System.Windows.Forms;
using System.Drawing;
//using System.Windows.Media;
using Color = System.Drawing.Color;
using Pen = System.Drawing.Pen;

namespace LineShapeLib
{
    public class MyLine
    {
        public void DrawLine(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            g.DrawLine(myPen, 500, 100, 600, 30);
        }
    }
    public class MyRectangle
    {
        public void DrawRectangle(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Rectangle myRec = new Rectangle(50, 10, 60, 100);
            g.DrawRectangle(myPen, myRec);
        }

    }
    public class MyEllipse
    {
        public void DrawEllipse(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Rectangle myRec = new Rectangle(100, 250, 60, 80);
            g.DrawEllipse(myPen, myRec);
        }
    }
    public class MyPolygon
    {
        private int NumSides = 5;
        private int R = 40;
        private Point Center = new Point(400, 300);
        private Point[] ArrPoints;
        private void GetPointsForPolygon(double angle)
        {
            double j = 0;
            for (int i = 0; i < NumSides + 1; i++)
            {
                ArrPoints[i].X = Center.X + (int) (Math.Round(Math.Cos(j / 180 * Math.PI) * R));
                ArrPoints[i].Y = Center.Y - (int) (Math.Round(Math.Sin(j / 180 * Math.PI) * R));
                j = j + angle;
            }
        }
        public void DrawPolygon(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ArrPoints = new Point[NumSides + 1];
            GetPointsForPolygon((double)(360.0 / (double)NumSides));
            Pen myPen = new Pen(Color.Black);
            g.DrawPolygon(myPen, ArrPoints);
        }
        
    }
    public class MyPolyline
    {
        private Point[] ArrPoints;
        private int NumPoints = 4;
        public void DrawPolyline(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            ArrPoints = new Point[NumPoints];
            ArrPoints[0] = new Point(330, 44);
            ArrPoints[1] = new Point(300, 110);
            ArrPoints[2] = new Point(444, 80);
            ArrPoints[3] = new Point(444, 160);
            g.DrawLines(myPen, ArrPoints);
        }
    }
}