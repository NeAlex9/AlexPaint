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
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(e, myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Rectangle>();

        }

        private void buttonPolygon_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(e, myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Polygone>();

        }

        private void buttonEllipse_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(e, myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Ellipse>();

        }

        private void buttonTriangle_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(e, myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Triangle>();

        }

        private void buttonPolyline_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(e, myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Polyline>();

        }

        private void buttonBrush_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(e, myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Brush>();

        }

        private void buttonLine_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.BreakDraw(e, myPaint.MyDrawingAssets, DrawPanel);
            myPaint.SetFigureForDraw<Line>();

        }


        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.PrepareForDrawing(e, myPaint.MyDrawingAssets);
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.DrawWhileMouseMove(e, myPaint.MyDrawingAssets, DrawPanel);
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.SetFigure(e, myPaint.MyDrawingAssets, DrawPanel);
        }


        private void ButtonColor_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;
            if (clickedButton != null)
            {
                LabelCurColor.BackColor = clickedButton.BackColor;
                myPaint.MyDrawingAssets.MyPen.Color = clickedButton.BackColor;
                myPaint.MyDrawingAssets.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MyDrawingAssets.MainCanvas), myPaint.MyDrawingAssets.MyPen);
                DrawPanel.Refresh();
            }
        }

        private void trackBarLineWidth_Scroll(object sender, EventArgs e)
        {
            var scrolledTrack = (sender as TrackBar);
            if (scrolledTrack != null)
            {
                myPaint.MyDrawingAssets.MyPen.Width = scrolledTrack.Value;
                myPaint.MyDrawingAssets.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MyDrawingAssets.MainCanvas), myPaint.MyDrawingAssets.MyPen);
                DrawPanel.Refresh();
            }
        }

        private void buttonPalette_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            LabelCurColor.BackColor = colorDialog.Color;
            myPaint.MyDrawingAssets.MyPen.Color = LabelCurColor.BackColor;
            myPaint.MyDrawingAssets.CurrentFigure.Redraw(Graphics.FromImage(myPaint.MyDrawingAssets.MainCanvas), myPaint.MyDrawingAssets.MyPen);
            DrawPanel.Refresh();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            myPaint.MyDrawingAssets.CurrentFigure.Reset(e, myPaint.MyDrawingAssets, DrawPanel);
        }
    }

}
