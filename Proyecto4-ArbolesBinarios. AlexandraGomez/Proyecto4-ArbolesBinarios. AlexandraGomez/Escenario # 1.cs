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
    public partial class Escenario1 : Form
    {
        public Escenario1()
        {
            InitializeComponent();
        }

        private void Escenario1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void menuItemGrafica_Click(object sender, EventArgs e)
        {
            Graphics lienzo = CreateGraphics();
            Pen lapiz = new Pen(Brushes.Black, 3);
            Font letra = new Font ("Arial", 13, FontStyle.Bold);

            // Realizacion de las lineas

            // Linea 1-2

            lienzo.DrawLine(lapiz, 305, 50, 205, 150);

            // linea 2-3
            lienzo.DrawLine(lapiz, 210, 150, 70, 248);

            // linea 3-4
            lienzo.DrawLine(lapiz, 88, 248, 40, 330);

            // linea 4-5
            lienzo.DrawLine(lapiz, 95, 248, 158, 328);

            // linea 5-6
            lienzo.DrawLine(lapiz, 200, 160, 290, 245);

            // linea 6-7
            lienzo.DrawLine(lapiz, 295, 265, 218, 355);

            // linea 7-8
            lienzo.DrawLine(lapiz, 300, 65, 424, 154);

            // linea 8-9
            lienzo.DrawLine(lapiz, 424, 154, 535, 250);

            // linea 9-10
            lienzo.DrawLine(lapiz, 535, 250, 600, 340);

            // linea 10-11
            lienzo.DrawLine(lapiz, 540, 265, 470, 355);

            // linea 11-12
            lienzo.DrawLine(lapiz, 432, 168, 408, 265);

            // Realizacion del nodo 1

            lienzo.FillEllipse(Brushes.Purple, 280, 45, 35, 35);
            lienzo.DrawEllipse(lapiz, 280, 45, 35, 35);
            lienzo.DrawString("50", letra, Brushes.White, 280, 50);

            // Realizacion del nodo 2

            lienzo.FillEllipse(Brushes.Purple, 175, 145, 35, 35);
            lienzo.DrawEllipse(lapiz, 175, 145, 35, 35);
            lienzo.DrawString("40", letra , Brushes.White, 175, 150);

            // Realizacion del nodo 3

            lienzo.FillEllipse(Brushes.Purple, 70, 235, 35, 35);
            lienzo.DrawEllipse(lapiz, 70, 235, 35, 35);
            lienzo.DrawString("30", letra, Brushes.White, 70, 240);

            // Realizacion del nodo 4

            lienzo.FillEllipse(Brushes.Purple, 10, 325, 35, 35);
            lienzo.DrawEllipse(lapiz, 10, 325, 35, 35);
            lienzo.DrawString("25", letra, Brushes.White, 10, 330);

            // Realizacion del nodo 5

            lienzo.FillEllipse(Brushes.Purple, 145, 325, 35, 35);
            lienzo.DrawEllipse(lapiz, 145, 325, 35, 35);
            lienzo.DrawString("35", letra, Brushes.White, 145, 330);

            // Realizacion del nodo 6

            lienzo.FillEllipse(Brushes.Purple, 210, 325, 35, 35);
            lienzo.DrawEllipse(lapiz, 210, 325, 35, 35);
            lienzo.DrawString("42", letra, Brushes.White, 210, 330);

            // Realizacion del nodo 7

            lienzo.FillEllipse(Brushes.Purple, 280, 235, 35, 35);
            lienzo.DrawEllipse(lapiz, 280, 235, 35, 35);
            lienzo.DrawString("45", letra, Brushes.White, 280, 240);

            // Realizacion del nodo 8

            lienzo.FillEllipse(Brushes.Purple, 575, 325, 35, 35);
            lienzo.DrawEllipse(lapiz, 575, 325, 35, 35);
            lienzo.DrawString("75", letra, Brushes.White, 575, 330);

            // Realizacion del nodo 9

            lienzo.FillEllipse(Brushes.Purple, 445, 325, 35, 35);
            lienzo.DrawEllipse(lapiz, 445, 325, 35, 35);
            lienzo.DrawString("65", letra, Brushes.White, 445, 330);

            // Realizacion del nodo 10

            lienzo.FillEllipse(Brushes.Purple, 510, 235, 35, 35);
            lienzo.DrawEllipse(lapiz, 510, 235, 35, 35);
            lienzo.DrawString("70", letra, Brushes.White, 510, 240);

            // Realizacion del nodo 11

            lienzo.FillEllipse(Brushes.Purple, 380, 235, 35, 35);
            lienzo.DrawEllipse(lapiz, 380, 235, 35, 35);
            lienzo.DrawString("55", letra, Brushes.White, 380, 240);

            // Realizacion del nodo 11

            lienzo.FillEllipse(Brushes.Purple, 405, 145, 35, 35);
            lienzo.DrawEllipse(lapiz, 405, 145, 35, 35);
            lienzo.DrawString("60", letra, Brushes.White, 405, 150);
        }

        private void menuItemPreOrden_Click(object sender, EventArgs e)
        {
            Graphics preorden;
            preorden = CreateGraphics();
            Font font = new Font("Arial", 10);
            Brush fontBrush = Brushes.Black;
            Pen ellipsePen = new Pen(Color.Purple, 1);

            preorden.DrawString("Preorden:", font, fontBrush, 10, 400);

            DrawNode(preorden, ellipsePen, "50", 105, 390);
            DrawNode(preorden, ellipsePen, "40", 145, 390);
            DrawNode(preorden, ellipsePen, "30", 185, 390);
            DrawNode(preorden, ellipsePen, "25", 225, 390);
            DrawNode(preorden, ellipsePen, "35", 265, 390);
            DrawNode(preorden, ellipsePen, "45", 305, 390);
            DrawNode(preorden, ellipsePen, "42", 345, 390);
            DrawNode(preorden, ellipsePen, "60", 385, 390);
            DrawNode(preorden, ellipsePen, "55", 425, 390);
            DrawNode(preorden, ellipsePen, "70", 465, 390);
            DrawNode(preorden, ellipsePen, "65", 505, 390);
            DrawNode(preorden, ellipsePen, "75", 545, 390);

            void DrawNode(Graphics g, Pen pen, string value, int x, int y)
            {
                g.DrawEllipse(pen, x, y, 35, 35);
                g.DrawString(value, font, fontBrush, x + 10, y + 10);
            }
        }

        private void menuItemInOrden_Click(object sender, EventArgs e)
        {
            Graphics inorden;
            inorden = CreateGraphics();
            Font font = new Font("Arial", 10);
            Brush fontBrush = Brushes.Black;
            Pen ellipsePen = new Pen(Color.Purple, 1);

            inorden.DrawString("In-orden:", font, fontBrush, 10, 450);

            DrawNode(inorden, ellipsePen, "25", 105, 440);
            DrawNode(inorden, ellipsePen, "30", 145, 440);
            DrawNode(inorden, ellipsePen, "35", 185, 440);
            DrawNode(inorden, ellipsePen, "40", 225, 440);
            DrawNode(inorden, ellipsePen, "42", 265, 440);
            DrawNode(inorden, ellipsePen, "45", 305, 440);
            DrawNode(inorden, ellipsePen, "50", 345, 440);
            DrawNode(inorden, ellipsePen, "55", 385, 440);
            DrawNode(inorden, ellipsePen, "60", 425, 440);
            DrawNode(inorden, ellipsePen, "65", 465, 440);
            DrawNode(inorden, ellipsePen, "70", 505, 440);
            DrawNode(inorden, ellipsePen, "75", 545, 440);

            void DrawNode(Graphics g, Pen pen, string value, int x, int y)
            {
                g.DrawEllipse(pen, x, y, 35, 35);
                g.DrawString(value, font, fontBrush, x + 10, y + 10);
            }

        }

        private void menuItemPostOrden_Click(object sender, EventArgs e)
        {
            Graphics postorden;
            postorden = CreateGraphics();
            Font font = new Font("Arial", 10);
            Brush fontBrush = Brushes.Black;
            Pen ellipsePen = new Pen(Color.Purple, 1);

            postorden.DrawString("Post-orden:", font, fontBrush, 10, 500);

            DrawNode(postorden, ellipsePen, "25", 105, 490);
            DrawNode(postorden, ellipsePen, "35", 145, 490);
            DrawNode(postorden, ellipsePen, "30", 185, 490);
            DrawNode(postorden, ellipsePen, "42", 225, 490);
            DrawNode(postorden, ellipsePen, "45", 265, 490);
            DrawNode(postorden, ellipsePen, "40", 305, 490);
            DrawNode(postorden, ellipsePen, "55", 345, 490);
            DrawNode(postorden, ellipsePen, "65", 385, 490);
            DrawNode(postorden, ellipsePen, "75", 425, 490);
            DrawNode(postorden, ellipsePen, "70", 465, 490);
            DrawNode(postorden, ellipsePen, "60", 505, 490);
            DrawNode(postorden, ellipsePen, "50", 545, 490);

            void DrawNode(Graphics g, Pen pen, string value, int x, int y)
            {
                g.DrawEllipse(pen, x, y, 35, 35);
                g.DrawString(value, font, fontBrush, x + 10, y + 10);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menuForm = new Menu();
            menuForm.Show();
            this.Hide();
        }
    }
}
