using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MenuCuenta : Form
    {
        public MenuCuenta()
        {
            InitializeComponent();
        }

        private void BSalir_Click(object sender, EventArgs e)   
        {
            this.Close();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (TBNombre != null && TBApellido != null && TBMail != null && TBContraseña != null && CBCargo != null)
            {
                string nombre = TBNombre.Text;
                string apellido = TBApellido.Text;
                string mail = TBMail.Text;
                string password = TBContraseña.Text;
                string cargo = CBCargo.Text;
            }
        }
    }
}
