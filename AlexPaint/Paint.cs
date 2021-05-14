using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using BaseFigure;
using AllFigures;
using System.Reflection;
using System;
using System.Windows.Forms;

namespace AlexPaint
{
    public class Paint
    {
        public Bitmap MainCanvas { get; set; }
        public Bitmap HelperCanvas { get; set; }
        public Figure CurrentFigureDrawner { set; get; }

        public List<Figure> AllFiguresDrawner { set; get; }

        public History MyHistory { set; get; }

        public Paint()
        {
            AllFiguresDrawner = new List<Figure>();
            AllFiguresDrawner.Add(new Line());
            AllFiguresDrawner.Add(new Ellipse());
            AllFiguresDrawner.Add(new Polygone());
            AllFiguresDrawner.Add(new Polyline());
            AllFiguresDrawner.Add(new AllFigures.Rectangle());
            AllFiguresDrawner.Add(new Triangle());
            MainCanvas = new Bitmap(1920, 1080);
            HelperCanvas = new Bitmap(1920, 1080);
            CurrentFigureDrawner = AllFiguresDrawner[0];
            MyHistory = new History();
        }

        public void SetFigureForDraw(Type typeFigureToDraw)
        {
            for (int i = 0; i < AllFiguresDrawner.Count; i++)
            {
                if (typeFigureToDraw.IsAssignableFrom(AllFiguresDrawner[i].GetType())
                    && !(typeFigureToDraw.IsAssignableFrom(CurrentFigureDrawner.GetType())))
                {
                    CurrentFigureDrawner = AllFiguresDrawner[i];
                    return;
                }

                /*if (AllFiguresDrawner[i] is T && !(CurrentFigureDrawner is T))
                {
                    CurrentFigureDrawner = AllFiguresDrawner[i];
                    return;
                }*/
            }
        }

        /*public T DownlodClassFromPlugin<T>(string dllName, string className, out Type type)
        {
            try
            {
                Assembly asm = Assembly.LoadFrom(@"Plugin.dll");
                object[] parameters = new object[] { new Size(27, 27), new Point(89, 2), @"trapeze.png" };
                Type type = asm.GetType(@"Plugin.CustomButton");
                Button obj = Activator.CreateInstance(type, parameters) as Button;
                obj.BringToFront();
                panelForFigures.Controls.Add(obj);
                obj.MouseClick += new MouseEventHandler(buttonTrapezoid_MouseClick);

                type = asm.GetType(@"Plugin.Trapezoid");
                Figure trapezoid = Activator.CreateInstance(type) as Figure;
                myPaint.AllFiguresDrawner.Add(trapezoid);
            }
            catch (Exception)
            {
                MessageBox.Show("Can't downlod plugin");

            }
    }*/

        public void GetMessageFromPluginButton(string dllName, string className)
        {
            /*Figure figure = DownlodClassFromPlugin<Figure>(@"Plugin.dll", "Plugin.Trapezoid", out Type type);
            AllFiguresDrawner.Add(figure);
            int x = 0;
            var t = x.GetType();
            SetFigureForDraw<>();*/
            /*Figure figure = DownlodClassFromPlugin<Figure>(dllName, className, out Type type);
            CurrentFigureDrawner = figure;*/
        }
    }
}