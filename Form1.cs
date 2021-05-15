using AlexPaint;
using AllFigures;
using BaseFigure;
using Plugin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GIUAndForms
{
    public partial class Form1 : Form
    {
        private Paint myPaint;

        private Serialization saver;

        public Form1()
        {
            InitializeComponent();
            myPaint = new Paint();
            saver = new Serialization();
            SaveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);
            KeyPreview = true;

        }

        public void DownloadPlugin(string libName, string buttonTypeName, string FigureTypeName, AlexPaint.Paint paint)
        {
            Type GetType(Type[] types, Type soughtType)
            {
                for (int i = 0; i < types.Length; i++)
                {
                    if (soughtType.IsAssignableFrom(types[i]))
                    {
                        return types[i];
                    }
                }

                return null;
            }

            try
            {
                Assembly asm = Assembly.LoadFrom(libName);
                Type[] types = asm.GetTypes();
                Type type = GetType(types, typeof(Button));
                if (!(type is null))
                {
                    object[] parameters = new object[] { paint, new Size(27, 27), new Point(89, 2) };
                    Button obj = Activator.CreateInstance(type, parameters) as Button;
                    obj.BringToFront();
                    panelForFigures.Controls.Add(obj);
                }

                type = GetType(types, typeof(Figure));
                if (!(type is null))
                {
                    Figure trapezoid = Activator.CreateInstance(type) as Figure;
                    myPaint.AllFiguresDrawner.Add(trapezoid);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't downlod plugin");
            }
        }

        private void buttonRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            myPaint.CurrentFigureDrawner.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw(typeof(AllFigures.Rectangle));
        }

        private void buttonPolygon_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.CurrentFigureDrawner.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw(typeof(AllFigures.Polygone));
        }

        private void buttonEllipse_MouseClick(object sender, MouseEventArgs e)
        {

            myPaint.CurrentFigureDrawner.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw(typeof(AllFigures.Ellipse));
        }

        private void buttonTriangle_MouseClick(object sender, MouseEventArgs e)
        {

            myPaint.CurrentFigureDrawner.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw(typeof(AllFigures.Triangle));
        }

        private void buttonPolyline_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.CurrentFigureDrawner.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw(typeof(AllFigures.Polyline));
        }

        private void buttonLine_MouseClick(object sender, MouseEventArgs e)
        {
            myPaint.CurrentFigureDrawner.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
            myPaint.SetFigureForDraw(typeof(AllFigures.Line));
        }

        private void buttonTrapeziod_MouseClick(object sender, MouseEventArgs e)
        {
            /*try
            {
                Assembly asm = Assembly.LoadFrom(@"Plugin.dll");
                Type t = asm.GetType("Plugin.Trapezoid", true, true);
                Figure obj = Activator.CreateInstance(t) as Figure;
                if (!(obj is null))
                {
                    myPaint.CurrentFigureDrawner.BreakDraw(Graphics.FromImage(myPaint.MainCanvas), new Point(e.X, e.Y));
                    myPaint.AllFiguresDrawner.Add(obj);
                    myPaint.SetFigureForDraw(t);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't downlod plugin");
            }*/
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if ((MouseButtons.Left & e.Button) != 0)
            {
                myPaint.CurrentFigureDrawner.PrepareForDrawing(new Point(e.X, e.Y), myPaint.MainCanvas);
            }
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                Graphics g = Graphics.FromImage(myPaint.HelperCanvas);
                g.Clear(Color.White);
                g.DrawImage(myPaint.CurrentFigureDrawner.CanvasWithoutCurrentFigure, 0, 0);
                myPaint.CurrentFigureDrawner.DrawWhileMouseMove(g, new Point(e.X, e.Y));
                DrawPanel.Image = myPaint.HelperCanvas;
                DrawPanel.Refresh();
            }
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left == e.Button)
            {
                Graphics g = Graphics.FromImage(myPaint.MainCanvas);
                myPaint.CurrentFigureDrawner.LeftMouseUpClick(g, new Point(e.X, e.Y));
                if (myPaint.CurrentFigureDrawner.HadTheFigureDrawn)
                {
                    myPaint.MyHistory.AddToAllDrawnFigures(myPaint.CurrentFigureDrawner.GetPointsForRedrawning());
                    myPaint.MyHistory.Pointer++;
                    myPaint.CurrentFigureDrawner.FinishDrawning();
                }
                DrawPanel.Image = myPaint.MainCanvas;
            }
            if (MouseButtons.Right == e.Button)
            {
                Graphics g = Graphics.FromImage(myPaint.MainCanvas);
                myPaint.CurrentFigureDrawner.RightMouseUpClick(g, new Point(e.X, e.Y));
                if (myPaint.CurrentFigureDrawner.HadTheFigureDrawn)
                {
                    myPaint.MyHistory.AddToAllDrawnFigures(myPaint.CurrentFigureDrawner.GetPointsForRedrawning());
                    myPaint.MyHistory.Pointer++;
                    myPaint.CurrentFigureDrawner.FinishDrawning();
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
                myPaint.CurrentFigureDrawner.MyPen.Color = clickedButton.BackColor;
                for (int i = 0; i < myPaint.AllFiguresDrawner.Count; i++)
                {
                    myPaint.AllFiguresDrawner[i].MyPen.Color = LabelCurColor.BackColor;
                }
                myPaint.CurrentFigureDrawner.Redraw(Graphics.FromImage(myPaint.MainCanvas));
                DrawPanel.Refresh();
            }
        }

        private void trackBarLineWidth_Scroll(object sender, EventArgs e)
        {
            var scrolledTrack = (sender as TrackBar);
            if (scrolledTrack != null)
            {
                for (int i = 0; i < myPaint.AllFiguresDrawner.Count; i++)
                {
                    myPaint.AllFiguresDrawner[i].MyPen.Width = scrolledTrack.Value;
                }
                myPaint.CurrentFigureDrawner.Redraw(Graphics.FromImage(myPaint.MainCanvas));
                DrawPanel.Refresh();
            }
        }

        private void buttonPalette_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            LabelCurColor.BackColor = colorDialog.Color;
            for (int i = 0; i < myPaint.AllFiguresDrawner.Count; i++)
            {
                myPaint.AllFiguresDrawner[i].MyPen.Color = LabelCurColor.BackColor;
            }
            myPaint.CurrentFigureDrawner.Redraw(Graphics.FromImage(myPaint.MainCanvas));
            DrawPanel.Refresh();
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            myPaint.MyHistory.Pointer--;
            Graphics g = Graphics.FromImage(myPaint.MainCanvas);
            myPaint.MyHistory.DrawFigures(g, myPaint.AllFiguresDrawner);
            myPaint.CurrentFigureDrawner.MyPen.Color = LabelCurColor.BackColor;
            myPaint.CurrentFigureDrawner.MyPen.Width = trackBarLineWidth.Value;
            DrawPanel.Refresh();
            for (int i = 0; i < myPaint.AllFiguresDrawner.Count; i++)
            {
                myPaint.AllFiguresDrawner[i].MyPen.Color = LabelCurColor.BackColor;
                myPaint.AllFiguresDrawner[i].MyPen.Width = trackBarLineWidth.Value;
            }
        }

        private void buttonRedo_Click(object sender, EventArgs e)
        {
            myPaint.MyHistory.Pointer++;
            Graphics g = Graphics.FromImage(myPaint.MainCanvas);
            myPaint.MyHistory.DrawFigures(g, myPaint.AllFiguresDrawner);
            myPaint.CurrentFigureDrawner.MyPen.Color = LabelCurColor.BackColor;
            myPaint.CurrentFigureDrawner.MyPen.Width = trackBarLineWidth.Value;
            DrawPanel.Refresh();
            for (int i = 0; i < myPaint.AllFiguresDrawner.Count; i++)
            {
                myPaint.AllFiguresDrawner[i].MyPen.Color = LabelCurColor.BackColor;
                myPaint.AllFiguresDrawner[i].MyPen.Width = trackBarLineWidth.Value;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                Serialization saver = new Serialization();
                var DrawnFiguresData = new List<FigureData>(myPaint.MyHistory.FiguresData);
                int numFigures = myPaint.MyHistory.Pointer;
                DrawnFiguresData.RemoveRange(numFigures, DrawnFiguresData.Count - numFigures);
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.WriteLine(saver.Serialize(DrawnFiguresData));
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло  так ):");
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Serialization writer = new Serialization();
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    myPaint.MyHistory.FiguresData = writer.Deserialize(reader.ReadToEnd());
                    myPaint.MyHistory.Pointer = myPaint.MyHistory.FiguresData.Count;
                    myPaint.MyHistory.DrawFigures(Graphics.FromImage(myPaint.MainCanvas), myPaint.AllFiguresDrawner);
                    for (int i = 0; i < myPaint.AllFiguresDrawner.Count; i++)
                    {
                        myPaint.AllFiguresDrawner[i].MyPen.Color = LabelCurColor.BackColor;
                        myPaint.AllFiguresDrawner[i].MyPen.Width = trackBarLineWidth.Value;
                    }
                }

                DrawPanel.Image = myPaint.MainCanvas;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void downloadPlaginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DownloadPlugin(openFileDialog1.FileName, @"Plugin.CustomButton", @"Plugin.Trapezoid", myPaint);
            }
        }
    }
}
