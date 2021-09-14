using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Controles : Clientes
    {
                
        //*************Metodo Cargar ***********/////
        public void Cargar(List<Clientes> lista)
        {
            //Instancia de la clase Cliente.
            Clientes p = new Clientes();
            //////////////////////////////
            
            
            //El campo codigo con su validacion.
            int cod;
            Console.Write("Digite el codigo: ");
            while (!Int32.TryParse(Console.ReadLine(), out cod))
            {
                Console.WriteLine("El dato ingresado no es un entero");
                Console.Write("Digite el codigo: ");
            }
            p.Codigo = Convert.ToInt32(cod);
            /////////////////////////////////////
            
            
            //El campo Nombre y su validacion
            string s;
            Console.Write("Digite el Nombre: ");
            s = Console.ReadLine();

            while (string.IsNullOrEmpty(s)) { 
                Console.WriteLine("El campo nombre no puede estar vacio");
                Console.Write("Digite el Nombre: ");
                s = Console.ReadLine();
            }
            p.Nombre = s;
            /////////////////////////////////////
            
            
            //El campo Fecha de Nacimiento y su validacion.
            Console.Write("Digite la Fecha de Nacimiento: ");
            p.FechaNacimiento = DateTime.Parse(Console.ReadLine());            
            
            DateTime FechaLimite= new DateTime(2003, 12, 31, 0, 0, 0);
            int fecha = DateTime.Compare(p.FechaNacimiento,FechaLimite );
            if (fecha>0)
            {
                Console.WriteLine("No se permite registrar menores de edad.");
                return;                
            }
            /////////////////////////////////// 


            //El campo Nbalance y su validacion.                   
            decimal nb;
            Console.Write("Digite el Balance: ");

            while (!decimal.TryParse(Console.ReadLine(), out nb))
            {
                Console.WriteLine("El dato ingresado no es un decimal");
                Console.Write("Digite el codigo: ");
            }        
            p.Nbalance = nb;
            /////////////////////////////////
            

            //Agregando todo el objeto p a la lista,
            lista.Add(p);
            ///////////////////////////////////
           
        }


        //**********Metodo Listar **************/////
        public void Listar(List<Clientes> lista)
        {
            foreach (Clientes lis in lista)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", lis.Codigo, lis.Nombre, lis.FechaNacimiento, "$"+lis.Nbalance);
            }
        }


        public void Eliminar(List<Clientes> lista)
        {
            int aux = 0;
            bool control = false;
            Console.Write("Digite el Codigo del registro a eliminar: ");
            aux = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lista.Count; i++)
            {
                Clientes cli = lista.ElementAt(i);
                if (cli.Codigo == aux)
                {
                    lista.RemoveAt(lista.LastIndexOf(cli));
                    control = true;
                    Console.WriteLine("Dato eliminado.");
                }
            }
            if (!control)
            {
                Console.WriteLine("Dato no existe en la lista.");
            }
            else
            {
                Listar(lista);
            }
        }
    }
}
