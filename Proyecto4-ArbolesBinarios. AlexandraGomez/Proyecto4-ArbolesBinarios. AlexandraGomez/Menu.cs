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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();

        }

        private void btnEscenario1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Escenario1
            Escenario1 escenario1Form = new Escenario1();

            // Mostrar el formulario Escenario1
            escenario1Form.Show();
            this.Hide();
        }

        private void btnEscenario2_Click(object sender, EventArgs e)
        {
            Escenario2 escenario2Form = new Escenario2();
            escenario2Form.Show();
            this.Hide();
        }
    }
}
