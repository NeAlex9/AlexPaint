// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AlexPaint
{
    public partial class Form1 : Form
    {
    
        private Paint myPaint;

        public Form1()
        {
            InitializeComponent();
            myPaint = new Paint();

        }
        
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            myPaint.SetFigureForDraw<Rectangle>();
        }
        
        private void buttonPolygon_Click(object sender, EventArgs e)
        {
            myPaint.SetFigureForDraw<Polygone>();
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            myPaint.SetFigureForDraw<Ellipse>();
        }

        private void buttonPolyline_Click(object sender, EventArgs e)
        {
            myPaint.SetFigureForDraw<Polyline>();
        }

        private void buttonBrush_Click(object sender, EventArgs e)
        {
            myPaint.SetFigureForDraw<Brush>();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            myPaint.SetFigureForDraw<Line>();
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            myPaint.SetFigureForDraw<Triangle>();
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                myPaint.CurrentFigure.LeftMouseDownClick(e.X, e.Y, myPaint.MainCanvas);
            }
        }
        
        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Graphics g = Graphics.FromImage(myPaint.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(myPaint.CurrentFigure.CanvasWithOriginalFigure, 0, 0);
                myPaint.CurrentFigure.Draw(g, e, myPaint.MyPen, myPaint.CurrentFigure.xStart, myPaint.CurrentFigure.yStart);
                DrawPanel.Image = myPaint.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                myPaint.MainCanvas = (Bitmap)myPaint.CurrentFigure.CanvasWithOriginalFigure.Clone();
                Graphics g = Graphics.FromImage(myPaint.MainCanvas);
                myPaint.CurrentFigure.LeftMouseUpClick(g, Graphics.FromImage(myPaint.CurrentFigure.CanvasWithOriginalFigure), e, myPaint.MyPen, myPaint.CurrentFigure.xStart, myPaint.CurrentFigure.yStart);
                DrawPanel.Image = myPaint.MainCanvas;
            }
        }


        private void ButtonColor_Click(object sender, EventArgs e)
        {
            var clickedButton =  sender as Button;
            if (clickedButton != null)
            {
                LabelCurColor.BackColor = clickedButton.BackColor;
                myPaint.MyPen.Color = clickedButton.BackColor;
            }
        }

        private void trackBarLineWidth_Scroll(object sender, EventArgs e)
        {
            var scrolledTrack = (sender as TrackBar);
            if (scrolledTrack != null)
            {
                myPaint.MyPen.Width = scrolledTrack.Value;
            }
        }

        private void buttonRectangle_MouseDown(object sender, MouseEventArgs e)
        {

        }

    }
    
}