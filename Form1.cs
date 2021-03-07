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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            MyLine myLine = new MyLine();            //Классы описаны в проекте LineShapelib
            myLine.DrawLine(e);
            MyRectangle myRec = new MyRectangle();
            myRec.DrawRectangle(e);
            MyEllipse myEllipse = new MyEllipse();
            myEllipse.DrawEllipse(e);
            MyPolygon myPoligon = new MyPolygon();
            myPoligon.DrawPolygon(e);
            MyPolyline myPolyline = new MyPolyline();
            myPolyline.DrawPolyline(e);
           
        }
    }
}