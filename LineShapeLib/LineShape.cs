using System;
using System.Windows.Forms;
using System.Drawing;


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
        private int numSides = 5;
        private int r = 40;
        private Point center = new Point(400, 300);
        private Point[] arrPoints;
        private void GetPointsForPolygon(double angle)
        {
            double j = 0;
            for (int i = 0; i < numSides + 1; i++)
            {
                arrPoints[i].X = center.X + (int) (Math.Round(Math.Cos(j / 180 * Math.PI) * r));
                arrPoints[i].Y = center.Y - (int) (Math.Round(Math.Sin(j / 180 * Math.PI) * r));
                j = j + angle;
            }
        }
        public void DrawPolygon(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            arrPoints = new Point[numSides + 1];
            GetPointsForPolygon((360.0 / numSides));
            Pen myPen = new Pen(Color.Black);
            g.DrawPolygon(myPen, arrPoints);
        }
        
    }
    public class MyPolyline
    {
        private Point[] arrPoints;
        private int NumPoints = 4;
        public void DrawPolyline(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            arrPoints = new Point[NumPoints];
            arrPoints[0] = new Point(330, 44);
            arrPoints[1] = new Point(300, 110);
            arrPoints[2] = new Point(444, 80);
            arrPoints[3] = new Point(444, 160);
            g.DrawLines(myPen, arrPoints);
        }
    }
}