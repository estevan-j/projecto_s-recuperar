using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_s
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Persona
        {
            string nombre;
            string apellido;
            string ci;
        }

        Persona cliente;

        private void controlNombre()
        {
            if (lblNombre.Text.Trim() != string.Empty && lblNombre.Text.All(char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(lblNombre, "");
            }
            else
            {
                if (!(lblNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(lblNombre, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(lblNombre, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                lblNombre.Focus();
            }
        }
        private void controlApellido()
        {
            if (lblApellido.Text.Trim() != string.Empty && lblApellido.Text.All(char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(lblApellido, "");
            }
            else
            {
                if (!(lblApellido.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(lblApellido, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(lblApellido, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                lblApellido.Focus();
            }
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            btnContinuar.Enabled = false;
        }

       
        public void borrarDatos()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            txtCedula.Clear();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            controlNombre();
            controlApellido();
            borrarDatos();
        }

       
    }
}
