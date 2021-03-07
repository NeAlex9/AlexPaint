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
using System.Windows.Forms;
using LineShapeLib;

namespace AlexPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in numericUpDown1.Controls)
                toolTipNumDeg.SetToolTip(c, "количество углов в многоугольнике");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*MyLine myLine = new MyLine();            //Классы описаны в проекте LineShapelib
            myLine.DrawLine(e);
            MyRectangle myRec = new MyRectangle();
            myRec.DrawRectangle(e);
            MyEllipse myEllipse = new MyEllipse();
            myEllipse.DrawEllipse(e);
            MyPolygon myPoligon = new MyPolygon();
            myPoligon.DrawPolygon(e);*/
        }     

        private void LabelCurColor_MouseHover(object sender, EventArgs e)
        {
            toolTipCurColor.SetToolTip(LabelCurColor, "Ваш цвет");    
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}