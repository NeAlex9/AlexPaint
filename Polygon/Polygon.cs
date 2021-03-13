using System.Drawing;
using System.Windows.Forms;
using BaseFigure;

namespace Polygon
{
    public class Polygone : Figure
    {
        public int NumSide { get; set; }
        public Point[] ArrPoints { get; set; }

        public Polygone(Color color, int width) : base(color, width)
        {
        }
        
        public override void Draw(PaintEventArgs e)
        {
        }
        
        public override void Clear(PaintEventArgs e)
        {
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