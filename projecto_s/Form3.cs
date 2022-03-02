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
        public Form3(int boletos, string destino,int numeroMaletas,double valorMaletas, double valorTotal)
        {
            InitializeComponent();
            
            this.boletos = boletos;
            this.numeroMaletas = numeroMaletas;
            this.valor = valorMaletas;
            this.valorTotal = valorTotal;
            this.destino = destino;

        }
        struct Persona
        {
            string nombre;
            string apellido;
            string ci;
        }

        Persona cliente;
        
        private int boletos;
        private int numeroMaletas;
        private double valor;
        private double valorTotal;
        private string destino;

        double valorMaletas;
        float iva;
        int subtotal;
        int total;

        




            private void Form3_Load(object sender, EventArgs e)
        {
            lblBoleto.Text=Convert.ToString(boletos);
            if (numeroMaletas >0)
            {
                lblMaleta.Text = Convert.ToString(numeroMaletas);
            }
            lblDestino.Text = destino;

           
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
