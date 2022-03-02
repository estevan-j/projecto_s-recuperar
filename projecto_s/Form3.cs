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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            
         
        }
        double subtotal;
        double valorExtra;
   
            private void Form3_Load(object sender, EventArgs e)
        {
            lblBoleto.Text=Convert.ToString(Datos.Boleto.asientos);
            if (Datos.Equipaje.numeroMaletas > 0)
            {
                lblMaleta.Text = Convert.ToString(Datos.Equipaje.numeroMaletas);
            }
            subtotal = Datos.Boleto.valor + Datos.Equipaje.valorTotal;
            valorExtra = subtotal * 0.12;
            Datos.Boleto.totalPagar = valorExtra + subtotal;
            lblDestino.Text = Datos.Boleto.destino;
            lblDatoN.Text = Datos.Persona.nombre;
            lblDatoA.Text = Datos.Persona.apellido;
            lblDatoCi.Text = Datos.Persona.cedula;
            lblDestino.Text = Datos.Boleto.destino;
            dtgTabla.Rows.Add(Convert.ToString(Datos.Boleto.asientos), Convert.ToString(Datos.Boleto.valor), 
                Convert.ToString(subtotal),Convert.ToString(valorExtra), Convert.ToString(Datos.Boleto.totalPagar));
            lblHoras.Text = Datos.Boleto.hora;
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
