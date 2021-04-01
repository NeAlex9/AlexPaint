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

        private void ButtonLine_Click(object sender, EventArgs e)
        {
        }
        
        private void LabelCurColor_MouseHover(object sender, EventArgs e)
        {
       
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            myPaint.CurrentFigure = new Rectangle();
        }
        
        private void buttonPolygon_Click(object sender, EventArgs e)
        {
            myPaint.CurrentFigure = new Polygone();
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            myPaint.CurrentFigure = new Ellipse();
        }

        private void buttonPolyline_Click(object sender, EventArgs e)
        {
            myPaint.CurrentFigure = new Polyline();
        }

        private void buttonBrush_Click(object sender, EventArgs e)
        {
            myPaint.CurrentFigure = new Brush();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            myPaint.CurrentFigure = new Line();
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            myPaint.CurrentFigure.OnMouseDownClick(e.X, e.Y, myPaint.MainCanvas);
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
            myPaint.MainCanvas = (Bitmap)myPaint.CurrentFigure.CanvasWithOriginalFigure.Clone();
           
            Graphics g = Graphics.FromImage(myPaint.MainCanvas);  //!!!!!!!1
            myPaint.CurrentFigure.OnMouseUpClick(g, Graphics.FromImage(myPaint.CurrentFigure.CanvasWithOriginalFigure), e, myPaint.MyPen, myPaint.CurrentFigure.xStart, myPaint.CurrentFigure.yStart);
            DrawPanel.Image = myPaint.MainCanvas;
        }

        private void DrawPanel_Click(object sender, EventArgs e)
        {
            
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

        private void DrawPanel_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}