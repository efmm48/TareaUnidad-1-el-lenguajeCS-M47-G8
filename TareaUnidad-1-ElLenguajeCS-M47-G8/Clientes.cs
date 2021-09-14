using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Clientes
    {
        

        private int codigo =0;
        private string nombre ="";
        private DateTime fechaNacimiento;
        private decimal nbalance =0;

        public Clientes()
        {
            
        }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public decimal Nbalance
        {
            get { return this.nbalance; }
            set { this.nbalance = value; }
        }
    }
}
