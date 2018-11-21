using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionCSharp
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            var Cliente1 = new CuentaAhorro(2000, "111", "Delman Chinchilla");
            
            Cliente1.TasaInteresAnual = 0.03;

            Menu(Cliente1);
            
        }//TERMINA EL MAIN()

        static void Menu(CuentaAhorro cliente)
        {
            Byte Opcion = 0;
            do
            {
                //double InteresMensual = 0;
                Console.WriteLine("===========================================");
                Console.WriteLine("\tSistema de Cuenta de Ahorros\n");
                Console.WriteLine("1.   Ver Informacion");
                Console.WriteLine("2.   Ultimo Interes mensual");
                Console.WriteLine("3.   Modifica Tasa interes anual");
                Console.WriteLine("4.   Ver Proyeccion de saldo de ahorro");
                Console.WriteLine("5.   Limpiar pantalla");
                Console.WriteLine("6.   SALIR");
                Console.WriteLine("--------------------");
                Console.Write("Seleccione su opcion: ");
                try
                {
                    Opcion = Byte.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine();

                switch (Opcion)
                {
                    case 1:
                        cliente.MostrarInfo();
                        break;
                    case 2:
                        cliente.UltimoInteresMensual();
                        //cliente.MostrarInfo();
                        //Console.WriteLine("El interes calculado del ultimo mes fue de: {0}", InteresMensual);
                        break;
                    case 3:
                        cliente.ModificaTasaInteresAnual();
                        break;
                    case 4:
                        Console.WriteLine("Indique el numero de meses que desea proyectar: ");
                        try
                        {
                            int CantMeses = int.Parse(Console.ReadLine());
                            cliente.ProyeccionSaldoAhorro(CantMeses);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }   
                        break;
                    case 5:
                        Console.Clear();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Escoja una opcion valida por favor!");
                        break;
                }
            } while(Opcion  != 6);
        }//TERMINA EL MENU()        

    }//TERMINA LA CLASE PROGRAM
}
