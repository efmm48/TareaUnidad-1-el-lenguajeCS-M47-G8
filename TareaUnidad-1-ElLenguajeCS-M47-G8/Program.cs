/*Crea una aplicación que permite generar pedir y luego listar 
un conjunto de clientes. Cada cliente es una clase que representa 
dicha entidad. Las propiedades de esta clase son código, 
nombre, fechaNacimiento y balance. El programa debe permitir 
capturar cliente hasta que el usuario diga que no desea continuar.

La captura de los datos no debe permitir valores nulo o blancos. 
No puede permitir clientes que tengan menos de 18 años.*/

using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Controles p = new Controles();

            List<Clientes> listaClientes = new List<Clientes>();
            int op = 0;

            void Menu()
            {
                
                Console.WriteLine("*********** MENU *********");                
                Console.WriteLine("* 1-Registrar Clientes.  *");
                Console.WriteLine("* 2-Listar Clientes      *");                
                Console.WriteLine("**************************");                
                Console.Write("\n Digite el numero de la opcion que desea: ");
                op = Convert.ToInt32(Console.ReadLine());
            }

            Menu();

            switch (op)
            {
                case 1:
                    string condicion1 ="";
                    while (condicion1 !="n")
                    {
                        p.Cargar(listaClientes);
                        Console.WriteLine("\n Si desea continuar con el registro de clientes presione <ENTER> de lo contrario <n>: ");
                        condicion1 = Console.ReadLine();
                    }
                    p.Listar(listaClientes);
                    Console.WriteLine("\n");
                    Menu();
                    break;

                case 2:
                    string condicion2 ="";
                    while (condicion2 !="n")
                    {
                        p.Listar(listaClientes);
                        Console.WriteLine("\n Si desea volver a listar los clientes presione <ENTER> de lo contrario <n>: ");
                        condicion2 = Console.ReadLine();

                    }
                    Console.WriteLine("\n");
                    Menu();
                    break;                

                default:
                    Console.WriteLine("\n Por favor digite una opcion valida: ");
                    Console.WriteLine("\n");
                    Menu();
                    break;
            }   

        }
    }
}
