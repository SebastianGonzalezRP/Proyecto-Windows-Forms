using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp4
{
    public partial class MenuCuenta : Form
    {
        Thread th;

        public static List<ClassLibrary2.Credencial> credenciales = new List<ClassLibrary2.Credencial>();
        public List<ClassLibrary2.Persona> personas = new List<ClassLibrary2.Persona>();
        public MenuCuenta()
        {
            InitializeComponent();
            setupData();
        }

        

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if (TBNombre.Text != "" && TBApellido.Text != "" && TBMail.Text != "" && TBContraseña.Text != "" && CBCargo.Text != "")
            {
                string nombre = TBNombre.Text;
                string apellido = TBApellido.Text;
                string mail = TBMail.Text;
                string password = TBContraseña.Text;
                string cargo = CBCargo.Text;
                string rut = TBRut.Text;
                foreach (ClassLibrary2.Credencial c in credenciales)
                {
                    if (c.rut == rut || c.username == mail)
                    {

                    }
                }
                MessageBox.Show("EXITOOO");
                TBNombre.Clear();
                TBApellido.Clear();
                TBContraseña.Clear();
                TBMail.Clear();
                TBRut.Clear();
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLogin()
        {
            Application.Run(new Login());
        }

        private void setupData()
        {
            credenciales.Add(new ClassLibrary2.Credencial("slgonzalez@miuandes.cl", "pass", "ALUMNO", "195672229"));
            credenciales.Add(new ClassLibrary2.Credencial("ejvial@miuandes", "pass", "ADMIN", "1"));

            personas.Add(new ClassLibrary2.Estudiante("Sebastian", "Gonzalez", "slgonzalez@miuandes.cl", "Ingenieria", "195672229"));
            personas.Add(new ClassLibrary2.Persona("Exequiel", "Vial", "ejvial@miuandes", "1"));
        }
    }
}
