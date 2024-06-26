using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto4_ArbolesBinarios.AlexandraGomez
{
    public partial class Escenario2 : Form
    {

        public Escenario2()
        {
            InitializeComponent();

        }

        private void graficaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Graphics lienzo = CreateGraphics();
            Pen lapiz = new Pen(Brushes.Black, 3);
            Font letra = new Font("Arial", 13, FontStyle.Bold);

            // Realizacion de las lineas

            // Linea 1-2

            lienzo.DrawLine(lapiz, 305, 50, 205, 150);

            // linea 2-3
            lienzo.DrawLine(lapiz, 210, 150, 70, 248);


            // linea 3-4
            lienzo.DrawLine(lapiz, 200, 160, 290, 245);


            // linea 4-5
            lienzo.DrawLine(lapiz, 300, 65, 424, 154);

            // linea 5-6
            lienzo.DrawLine(lapiz, 424, 154, 535, 250);

            // linea 6-7
            lienzo.DrawLine(lapiz, 540, 265, 470, 355);

            // linea 7-8
            lienzo.DrawLine(lapiz, 432, 168, 408, 265);

            // Realizacion del nodo 1

            lienzo.FillEllipse(Brushes.Salmon, 280, 45, 35, 35);
            lienzo.DrawEllipse(lapiz, 280, 45, 35, 35);
            lienzo.DrawString("26", letra, Brushes.White, 280, 50);

            // Realizacion del nodo 2

            lienzo.FillEllipse(Brushes.Salmon, 175, 145, 35, 35);
            lienzo.DrawEllipse(lapiz, 175, 145, 35, 35);
            lienzo.DrawString("20", letra, Brushes.White, 175, 150);

            // Realizacion del nodo 3

            lienzo.FillEllipse(Brushes.Salmon, 70, 235, 35, 35);
            lienzo.DrawEllipse(lapiz, 70, 235, 35, 35);
            lienzo.DrawString("17", letra, Brushes.White, 70, 240);


            // Realizacion del nodo 4

            lienzo.FillEllipse(Brushes.Salmon, 280, 235, 35, 35);
            lienzo.DrawEllipse(lapiz, 280, 235, 35, 35);
            lienzo.DrawString("25", letra, Brushes.White, 280, 240);


            // Realizacion del nodo 5

            lienzo.FillEllipse(Brushes.Salmon, 445, 325, 35, 35);
            lienzo.DrawEllipse(lapiz, 445, 325, 35, 35);
            lienzo.DrawString("37", letra, Brushes.White, 445, 330);

            // Realizacion del nodo 6

            lienzo.FillEllipse(Brushes.Salmon, 510, 235, 35, 35);
            lienzo.DrawEllipse(lapiz, 510, 235, 35, 35);
            lienzo.DrawString("55", letra, Brushes.White, 510, 240);

            // Realizacion del nodo 7

            lienzo.FillEllipse(Brushes.Salmon, 380, 235, 35, 35);
            lienzo.DrawEllipse(lapiz, 380, 235, 35, 35);
            lienzo.DrawString("28", letra, Brushes.White, 380, 240);

            // Realizacion del nodo 8

            lienzo.FillEllipse(Brushes.Salmon, 405, 145, 35, 35);
            lienzo.DrawEllipse(lapiz, 405, 145, 35, 35);
            lienzo.DrawString("31", letra, Brushes.White, 405, 150);


        }

        private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics preorden;
            preorden = CreateGraphics();
            Font font = new Font("Arial", 10);
            Brush fontBrush = Brushes.Black;
            Pen ellipsePen = new Pen(Color.DeepPink, 1);

            preorden.DrawString("Preorden:", font, fontBrush, 10, 400);

            DrawNode(preorden, ellipsePen, "26", 105, 390);
            DrawNode(preorden, ellipsePen, "20", 145, 390);
            DrawNode(preorden, ellipsePen, "17", 185, 390);
            DrawNode(preorden, ellipsePen, "25", 225, 390);
            DrawNode(preorden, ellipsePen, "24", 265, 390);
            DrawNode(preorden, ellipsePen, "31", 305, 390);
            DrawNode(preorden, ellipsePen, "28", 345, 390);
            DrawNode(preorden, ellipsePen, "55", 385, 390);
            DrawNode(preorden, ellipsePen, "37", 425, 390);
           

            Graphics inorden;
            inorden = CreateGraphics();
            Font font2 = new Font("Arial", 10);
            Brush fontBrus2 = Brushes.Black;
            Pen ellipsePen2 = new Pen(Color.Blue, 1);

            inorden.DrawString("In-orden:", font, fontBrush, 10, 450);

            DrawNode(inorden, ellipsePen2, "17", 105, 440);
            DrawNode(inorden, ellipsePen2, "20", 145, 440);
            DrawNode(inorden, ellipsePen2, "24", 185, 440);
            DrawNode(inorden, ellipsePen2, "25", 225, 440);
            DrawNode(inorden, ellipsePen2, "26", 265, 440);
            DrawNode(inorden, ellipsePen2, "28", 305, 440);
            DrawNode(inorden, ellipsePen2, "31", 345, 440);
            DrawNode(inorden, ellipsePen2, "37", 385, 440);
            DrawNode(inorden, ellipsePen2, "55", 425, 440);
            

            Graphics postorden;
            postorden = CreateGraphics();
            Font font3 = new Font("Arial", 10);
            Brush fontBrush3 = Brushes.Black;
            Pen ellipsePen3 = new Pen(Color.Brown, 1);

            postorden.DrawString("Post-orden:", font, fontBrush, 10, 500);

            DrawNode(postorden, ellipsePen3, "17", 105, 490);
            DrawNode(postorden, ellipsePen3, "24", 145, 490);
            DrawNode(postorden, ellipsePen3, "25", 185, 490);
            DrawNode(postorden, ellipsePen3, "20", 225, 490);
            DrawNode(postorden, ellipsePen3, "28", 265, 490);
            DrawNode(postorden, ellipsePen3, "37", 305, 490);
            DrawNode(postorden, ellipsePen3, "55", 345, 490);
            DrawNode(postorden, ellipsePen3, "31", 385, 490);
            DrawNode(postorden, ellipsePen3, "26", 425, 490);
            

            void DrawNode(Graphics g, Pen pen, string value, int x, int y)
            {
                g.DrawEllipse(pen, x, y, 35, 35);
                g.DrawString(value, font, fontBrush, x + 10, y + 10);
            }


        }

        private void MouseMove2(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.Show();
            this.Hide();
        }
    }
}
