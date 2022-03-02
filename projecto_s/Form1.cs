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
       
        private void controlNombre()
        {
            if (txtNombre.Text.Trim() != string.Empty && txtNombre.Text.All(char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(txtNombre, "");
            }
            else
            {
                if (!(txtNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtNombre, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtNombre, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                txtNombre.Focus();
            }
        }
        private void controlApellido()
        {
            if (txtApellido.Text.Trim() != string.Empty && txtApellido.Text.All(char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(txtApellido, "");
            }
            else
            {
                if (!(txtApellido.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtApellido, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtApellido, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                txtApellido.Focus();
            }
        }
        private void controlCedula()
        {
            if (txtCedula.Text.Trim() != string.Empty && txtCedula.Text.All(char.IsNumber))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(txtCedula, "");
            }
            else
            {
                if (!(txtCedula.Text.All(Char.IsNumber)))
                {
                    errorProvider1.SetError(txtCedula, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtCedula, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                txtCedula.Focus();
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
            borrarDatos();
            Form2 eleccion = new Form2();
           
            eleccion.Show();
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            controlNombre();
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            controlApellido();
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            controlCedula();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
