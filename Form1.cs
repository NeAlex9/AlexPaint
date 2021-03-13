// using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

using System;
using System.Windows.Forms;

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
            
        }     

        private void LabelCurColor_MouseHover(object sender, EventArgs e)
        {
            toolTipCurColor.SetToolTip(LabelCurColor, "Ваш цвет");    
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
    }
}