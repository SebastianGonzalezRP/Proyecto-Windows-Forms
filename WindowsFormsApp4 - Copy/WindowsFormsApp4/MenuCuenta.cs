﻿using System;
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
            string nombre = TBNombre.Text;
            string apellido = TBApellido.Text;
            string mail = TBMail.Text;
            string password = TBContraseña.Text;
            string cargo = CBCargo.Text;
            string rut = TBRut.Text;

            if (nombre != "" && apellido != "" && mail != "" && password != "" && cargo != "" && rut != "") //Comprobando Que se llenen Todos los Datos Requeridos
            {
                // Almacenando Los Text Box en variables
                
                foreach (ClassLibrary2.Credencial c in credenciales)
                {
                    if (c.rut == rut || c.username == mail) //Ya Existe un Usuario Con esos Datos -->Error
                    {
                        MessageBox.Show("Imposible Crear Usuario");
                        break;
                    }
                }
                ClassLibrary2.Credencial a = new ClassLibrary2.Credencial(mail, password,cargo,rut);
                credenciales.Add(a); //Agrega la credencial de la nueva cuenta, asociada a la persona mediante el rut

                if (cargo == "ALUMNO") //Crea La nueva cuenta como Estudiante
                {
                    ClassLibrary2.Estudiante b = new ClassLibrary2.Estudiante(nombre, apellido, mail, "", rut);
                    personas.Add(b);
                }
                else if (cargo == "PROFESOR")//Crea La nueva cuenta como Profesor
                {
                    ClassLibrary2.Profesor b = new ClassLibrary2.Profesor(nombre, apellido, mail, "", rut);
                    personas.Add(b);
                }
                else if (cargo == "ADMIN")//Crea La nueva cuenta como Admin
                {
                    ClassLibrary2.Persona b = new ClassLibrary2.Persona(nombre, apellido, mail, rut);
                    personas.Add(b);
                }
                //Limpiando Los TextBox despues de recibir parametros
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
