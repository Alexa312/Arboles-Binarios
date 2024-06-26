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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
              string contraseñaIngresada = txtContraseña.Text;

                // Verificar si la contraseña ingresada es correcta
                if (contraseñaIngresada == "UNAD")
                {
 
                   // Crear una instancia del formulario Menu
                    Menu menuForm = new Menu();

                   // Mostrar el formulario Menu
                    menuForm.Show();

                  // Ocultar el formulario actual
                   this.Hide();
                }
                else
                {
                    // La contraseña es incorrecta, mostrar un mensaje de error
                    MessageBox.Show("Contraseña incorrecta. Inténtalo de nuevo.","Confirmacion");
                }
            
        }
    }
}
