using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        struct Destino
        {
            public string lugarDeDestino;
            public double precio;
            public string horario;
        }
        struct Equipaje
        {
            public int numeroMaletas;
            public double valorTotal;
        }
        struct Boleto
        {
            public int asientos;
            public double valor;
            public double totalPagar;
            public string destino;
        }
        Equipaje maleta;
        Boleto compra;
        Destino[] lugares = new Destino[5];
        public Form2()
        {
            InitializeComponent();
            lugares[0].lugarDeDestino = "Guayaquil";
            lugares[0].precio = 9;
            lugares[0].horario = "13:00";
            lugares[1].lugarDeDestino = "Cuenca";
            lugares[1].precio = 15;
            lugares[1].horario = "15:00";
            lugares[2].lugarDeDestino = "Napo";
            lugares[2].precio = 10;
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
            llenarDatos();
            limpiarDatos();
        }

        public void limpiarDatos()
        {
            txtBoletos.Text = null;
            txtCantidad.Text = null;
           
        }
        public void llenarDatos()
        {
            if (cmbDestinos.SelectedIndex > -1)
            {
                errorProvider1.Clear();
                compra.destino = cmbDestinos.Text;
                try
                {
                    errorProvider2.Clear();
                    compra.asientos = int.Parse(txtBoletos.Text);

                    validarMaletas();
                }
                catch (FormatException)
                {
                    if (txtBoletos.Text == "")
                    {
                        errorProvider2.SetError(txtBoletos, "*Ingresa el número de boletos");
                    }
                    else{
                        MessageBox.Show("Ingresa valores numéricos","Error Boletos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }     
            }
            else 
            {
                errorProvider1.SetError(cmbDestinos, "*Selecciona un lugar");
            }
            
        }
        public void validarMaletas()
        {
            if (rbtSi.Checked)
            {
                try
                {
                    maleta.numeroMaletas = int.Parse(txtCantidad.Text);
                }
                catch (FormatException)
                {
                    if (txtCantidad.Text == "")
                    {
                        errorProvider3.SetError(txtCantidad, "*Ingresa el número ");
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
                     compra.valor = 9 * numero;
                    maleta.valorTotal = 1 * maletas;
                    compra.totalPagar = compra.valor + maleta.valorTotal;
                    break;
                case 1:
                    compra.valor = 9 * numero;
                    maleta.valorTotal = 1 * maletas;
                    compra.totalPagar = compra.valor + maleta.valorTotal;
                    break;
                case 2:
                    compra.valor = 9 * numero;
                    maleta.valorTotal = 1 * maletas;
                    compra.totalPagar = compra.valor + maleta.valorTotal;
                    break;
                case 3:
                    compra.valor = 9 * numero;
                    maleta.valorTotal = 1 * maletas;
                    compra.totalPagar = compra.valor + maleta.valorTotal;
                    break;
                case 4:
                    compra.valor = 9 * numero;
                    maleta.valorTotal = 1 * maletas;
                    compra.totalPagar = compra.valor + maleta.valorTotal;
                    break;
            }
        }
      
    }

       
}

