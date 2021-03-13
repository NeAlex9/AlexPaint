using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Media.Converters;


namespace LineShapeLib       //TODO классы для рисования фигур
{
    
    public abstract class Figure{
        public Color color { get; set; }
        public int width   { get; set; }

        public int x { get; set; }
        public int y { get; set; }

        public Figure(Color color, int width)
        {
            this.color = color;
            this.width = width;
        }
    } 
    
    public class MyLine : Figure
    {

        public MyLine(Color color, int width) : base(color, width){}
        public void DrawLine(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            g.DrawLine(myPen, 500, 100, 600, 30);
        }
    }
    
    public class MyRectangle : Figure
    {
        public MyRectangle(Color color, int width) : base(color, width){}
        public void DrawRectangle(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Rectangle myRec = new Rectangle(50, 10, 60, 100);
            g.DrawRectangle(myPen, myRec);
        }

    }
    
    public class MyEllipse : Figure
    {
    
        public MyEllipse(Color color, int width) : base(color, width){}
        public void DrawEllipse(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black);
            Rectangle myRec = new Rectangle(100, 250, 60, 80);
            g.DrawEllipse(myPen, myRec);
        }
    }
    
    public class MyPolygon : Figure
    {
        private int numSides = 5;
        private int r = 40;
        /*private Point center = new Point(400, 300);*/
        
        private Point[] arrPoints;
        
        public MyPolygon(Color color, int width) : base(color, width){}
        private void GetPointsForRegularPolygon(double angle)
        {
            double j = 0;
            for (int i = 0; i < numSides + 1; i++)
            {
                arrPoints[i].X = x + (int) (Math.Round(Math.Cos(j / 180 * Math.PI) * r));
                arrPoints[i].Y = y - (int) (Math.Round(Math.Sin(j / 180 * Math.PI) * r));
                j = j + angle;
            }
        }
        public void DrawPolygon(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            arrPoints = new Point[numSides + 1];
            GetPointsForRegularPolygon((360.0 / numSides));
            Pen myPen = new Pen(Color.Black);
            g.DrawPolygon(myPen, arrPoints);
        }
    }
}