using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto_s
{
    public  class Datos
    {
        
       public struct Persona
        {
            static public string apellido;
            static public string nombre;
            static public string cedula;
        }
     
        public struct Equipaje
        {
            static public int numeroMaletas;
            static public double valorTotal;
        }
        public struct Boleto
        {
            static public int asientos;
            static public double valor;
            static public double totalPagar;
            static public string hora;
            static public string destino;
        }
    }
}
