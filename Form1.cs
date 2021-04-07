// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

using BaseFigure;
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
            KeyPreview = true;
        }

        private void buttonRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            myPaint.CurrentFigure.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw<Rectangle>();
        }

        private void buttonPolygon_MouseClick(object sender, MouseEventArgs e)
        { 
            myPaint.CurrentFigure.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw<Polygone>();
        }

        private void buttonEllipse_MouseClick(object sender, MouseEventArgs e)
        {
            
            myPaint.CurrentFigure.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw<Ellipse>();
        }

        private void buttonTriangle_MouseClick(object sender, MouseEventArgs e)
        {
           
            myPaint.CurrentFigure.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw<Triangle>();
        }

        private void buttonPolyline_MouseClick(object sender, MouseEventArgs e)
        {
            
            myPaint.CurrentFigure.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw<Polyline>();
        }
        
        private void buttonLine_MouseClick(object sender, MouseEventArgs e)
        {
            
            myPaint.CurrentFigure.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw<Line>();
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                myPaint.CurrentFigure.PrepareForDrawing(new Point(e.X, e.Y), myPaint.MainCanvas);
            }
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                Graphics g = Graphics.FromImage(myPaint.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(myPaint.CurrentFigure.CanvasWithoutCurrentFigure, 0, 0);
                myPaint.CurrentFigure.DrawWhileMouseMove(g, new Point(e.X, e.Y));
                DrawPanel.Image = myPaint.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                Graphics g = Graphics.FromImage(myPaint.MainCanvas);
                myPaint.CurrentFigure.LeftMouseUpClick(g, new Point(e.X, e.Y));
                if (myPaint.CurrentFigure.HadTheFigureDrawn)
                {

                    myPaint.MyHistory.AllDrawnFigures.Add(myPaint.CurrentFigure.Clone(myPaint.MainCanvas));
                    myPaint.MyHistory.Pointer++;
                    myPaint.CurrentFigure.FinishDrawning();
                }
                DrawPanel.Image = myPaint.MainCanvas;
            }
            if (MouseButtons.Right == e.Button)
            {
                Graphics g = Graphics.FromImage(myPaint.MainCanvas);
                myPaint.CurrentFigure.RightMouseUpClick(g, new Point(e.X, e.Y));
                if (myPaint.CurrentFigure.HadTheFigureDrawn)
                {
                    myPaint.MyHistory.AllDrawnFigures.Add(myPaint.CurrentFigure.Clone(myPaint.MainCanvas));
                    myPaint.MyHistory.Pointer++;
                    myPaint.CurrentFigure.FinishDrawning();
                }
                DrawPanel.Image = myPaint.MainCanvas;
            }
        }  

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton != null)
            {
                LabelCurColor.BackColor = clickedButton.BackColor;
                myPaint.CurrentFigure.MyPen.Color = clickedButton.BackColor;
                for (int i = 0; i < myPaint.AllFigures.Count; i++)
                {
                    myPaint.AllFigures[i].MyPen.Color = LabelCurColor.BackColor;
                }
                myPaint.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MainCanvas));
                DrawPanel.Refresh();
            }
        }

        private void trackBarLineWidth_Scroll(object sender, EventArgs e)
        {
            var scrolledTrack = (sender as TrackBar);
            if (scrolledTrack != null)
            {
                for (int i = 0; i < myPaint.AllFigures.Count; i++)
                {
                    myPaint.AllFigures[i].MyPen.Width = scrolledTrack.Value;
                }
                myPaint.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MainCanvas));
                DrawPanel.Refresh();
            }
        }

        private void buttonPalette_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            LabelCurColor.BackColor = colorDialog.Color;
            for (int i = 0; i < myPaint.AllFigures.Count; i++)
            {
                myPaint.AllFigures[i].MyPen.Color = LabelCurColor.BackColor;
            }
            myPaint.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MainCanvas));
            DrawPanel.Refresh();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            myPaint.MyHistory.Pointer--;
            Graphics g = Graphics.FromImage(myPaint.MainCanvas);
            myPaint.MyHistory.DrawFigures(g);
            DrawPanel.Refresh();
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            myPaint.MyHistory.Pointer++;
            Graphics g = Graphics.FromImage(myPaint.MainCanvas);
            myPaint.MyHistory.DrawFigures(g);
            DrawPanel.Refresh();
        }
    }

}
