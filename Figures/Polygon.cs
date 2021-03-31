using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace AlexPaint
{
    public class Polygone : Figure
    {
        public int NumSide { get; set; }
        public List<Point> Points { get; set; }

        public Polygone()
        {
            Points = new List<Point>();
        }
        
        public override void Draw(Graphics g, MouseEventArgs e, Pen myPen, int xStart, int yStart)
        {
            int len = Points.Count;
            if (len > 1)
            {
                g.DrawLine(myPen, Points[len - 2], Points[len - 1]);    
            }   
        }
        
        public override void OnMouseDownClick(int xClick, int yClick)
        {
            Points.Add(new Point(xClick, yClick));
        }
        
        public override void OnMouseUpClick(Graphics g, MouseEventArgs e, Pen myPen, int xClick, int yClick)
        {
            int len = Points.Count, round = 20;
            
            if ((Points[0].X - round < Points[len - 1].X && Points[0].X + round > Points[len - 1].X) &&
                (Points[0].Y - round < Points[len - 1].Y && Points[0].Y + round > Points[len - 1].Y) &&
                (len > 1))
            {
                Points[len - 1] = Points[0];
                Draw(g, e, myPen, xClick, yClick);
                Points.Clear();
                return;
            }
            Draw(g, e, myPen, xClick, yClick);
        }
    }
}

/* TODO ПравильныйМногоугольник
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
    GetPointsForPolygon((360.0 / numSides));
    Pen myPen = new Pen(Color.Black);
    g.DrawPolygon(myPen, arrPoints);
}*/