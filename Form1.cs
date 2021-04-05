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
            KeyPreview = true;
        }

        private void buttonRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(new Point(e.X, e.Y), myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Rectangle>();
        }

        private void buttonPolygon_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(new Point(e.X, e.Y), myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Polygone>();
        }

        private void buttonEllipse_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(new Point(e.X, e.Y), myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Ellipse>();
        }

        private void buttonTriangle_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(new Point(e.X, e.Y), myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Triangle>();
        }

        private void buttonPolyline_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(new Point(e.X, e.Y), myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Polyline>();
        }

        private void buttonBrush_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(new Point(e.X, e.Y), myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Brush>();
        }

        private void buttonLine_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(new Point(e.X, e.Y), myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Line>();
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.PrepareForDrawing(new Point(e.X, e.Y), e.Button, myPaint.MyDrawingAssets);
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.DrawWhileMouseMove(new Point(e.X, e.Y), e.Button, myPaint.MyDrawingAssets, DrawPanel);
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.SetFigure(new Point(e.X, e.Y), e.Button, myPaint.MyDrawingAssets, DrawPanel);
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton != null)
            {
                LabelCurColor.BackColor = clickedButton.BackColor;
                myPaint.MyDrawingAssets.CurrentFigure.MyPen.Color = clickedButton.BackColor;
                for (int i = 0; i < myPaint.AllFigures.Count; i++)
                {
                    myPaint.AllFigures[i].MyPen.Color = LabelCurColor.BackColor;
                }
                myPaint.MyDrawingAssets.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MyDrawingAssets.MainCanvas));
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
                myPaint.MyDrawingAssets.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MyDrawingAssets.MainCanvas));
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
            myPaint.MyDrawingAssets.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MyDrawingAssets.MainCanvas));
            DrawPanel.Refresh();
        }
    }

}
