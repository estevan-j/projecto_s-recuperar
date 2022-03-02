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
    public partial class Form2 : Form 
    {
        struct Destino
        {
            public string lugarDeDestino;
            public double precio;
            public string horario;
        }

        Destino[] lugares = new Destino[5];
        public Form2()
        {
            InitializeComponent();
            cmbDestinos.DropDownStyle = ComboBoxStyle.DropDownList;
            lugares[0].lugarDeDestino = "Guayaquil";
            lugares[0].precio = 9;
            lugares[0].horario = "13:00";
            lugares[1].lugarDeDestino = "Cuenca";
            lugares[1].precio = 14.6;
            lugares[1].horario = "15:00";
            lugares[2].lugarDeDestino = "Napo";
            lugares[2].precio = 10.3;
            lugares[2].horario = "12:00";
            lugares[3].lugarDeDestino = "Loja";
            lugares[3].precio = 18;
            lugares[3].horario = "18:00";
            lugares[4].lugarDeDestino = "Carchi";
            lugares[4].precio = 7.5;
            lugares[4].horario = "17:00";
            cmbDestinos.Items.Add(lugares[0].lugarDeDestino);
            cmbDestinos.Items.Add(lugares[1].lugarDeDestino);
            cmbDestinos.Items.Add(lugares[2].lugarDeDestino);
            cmbDestinos.Items.Add(lugares[3].lugarDeDestino);
            cmbDestinos.Items.Add(lugares[4].lugarDeDestino);
            foreach (Destino lugares in lugares)
            {
                ListViewItem items = new ListViewItem();
                items = lstLugares.Items.Add(lugares.lugarDeDestino);
                items.SubItems.Add(lugares.precio.ToString());
                items.SubItems.Add(lugares.horario);
            }
        }

        private void rbtSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSi.Checked)
            {
                lblCantidad.Visible = true;
                txtCantidad.Visible = true;
            }
            else
            {
                lblCantidad.Visible = false;
                txtCantidad.Visible = false;
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            Datos.Equipaje.numeroMaletas = 0;
            if (cmbDestinos.SelectedIndex > -1)
            {
                errorProvider1.Clear();
                Datos.Boleto.destino = cmbDestinos.Text;
                try
                {
                    errorProvider2.Clear();
                    Datos.Boleto.asientos = int.Parse(txtBoletos.Text);
                    validarMaletas();
                    calcularSubtotal(Datos.Boleto.asientos,Datos.Equipaje.numeroMaletas);
                    limpiarDatos();
                    Form factura = new Form3();
                    factura.Show();
                    this.Close();
                }
                catch (FormatException)
                {
                    if (txtBoletos.Text == "")
                    {
                        errorProvider2.SetError(txtBoletos, "Ingresa el número de boletos");
                    }
                    else
                    {
                        MessageBox.Show("Ingresa valores numéricos", "Error Boletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                errorProvider1.SetError(cmbDestinos, "Selecciona un lugar");
            }
        }

        public void limpiarDatos()
        {
            txtBoletos.Text = null;
            txtCantidad.Text = null;
            cmbDestinos.SelectedIndex = -1;
        }
       
        public void validarMaletas()
        {
            if (rbtSi.Checked)
            {
                try
                {
                    Datos.Equipaje.numeroMaletas = int.Parse(txtCantidad.Text);
                }
                catch (FormatException)
                {
                    if (txtCantidad.Text == "")
                    {
                        errorProvider3.SetError(txtCantidad, "Ingresa el número de maletas");
                    }
                    else
                    {
                        errorProvider3.Clear();
                        MessageBox.Show("Ingresa valores numéricos","Error Maletas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void calcularSubtotal(int numero, int maletas)
        {
            switch (cmbDestinos.SelectedIndex){
                case 0:
                    Datos.Boleto.valor = 9 * Datos.Boleto.asientos;
                    Datos.Equipaje.valorTotal = 1 * Datos.Equipaje.numeroMaletas;
                    Datos.Boleto.hora = lugares[0].horario;
                    break;
                case 1:
                    Datos.Boleto.valor = 14.6 * Datos.Boleto.asientos;
                    Datos.Equipaje.valorTotal = 1 * Datos.Equipaje.numeroMaletas;
                    Datos.Boleto.hora = lugares[1].horario;
                    break;
                case 2:
                    Datos.Boleto.valor = 10.3 * Datos.Boleto.asientos;
                    Datos.Equipaje.valorTotal = 1 * Datos.Equipaje.numeroMaletas;
                    Datos.Boleto.hora = lugares[2].horario;
                    break;
                case 3:
                    Datos.Boleto.valor = 18 * Datos.Boleto.asientos;
                    Datos.Equipaje.valorTotal = 1 * Datos.Equipaje.numeroMaletas;
                    Datos.Boleto.hora = lugares[3].horario;
                    break;
                case 4:
                    Datos.Boleto.valor = 7.5 * Datos.Boleto.asientos;
                    Datos.Equipaje.valorTotal = 1 * Datos.Equipaje.numeroMaletas;
                    Datos.Boleto.hora = lugares[4].horario;
                    break;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

       
}

