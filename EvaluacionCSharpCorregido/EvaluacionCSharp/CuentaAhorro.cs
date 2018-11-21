using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionCSharp
{
    
    class CuentaAhorro : Cliente
    {
        public double TasaInteresAnual { get; set; }    //Probando Public Y NO STATIC como se pidio
        static double SaldoAhorro;
        private const int ano = 12;
        public CuentaAhorro(double saldoahorro, string codigo, string nombre)
            : base(codigo, nombre)
        {
            SaldoAhorro = saldoahorro;
        }

        public new void MostrarInfo()   //Usando por sugerencia del Visual Studio la palabra NEW
        {
            base.MostrarInfo();
            /*Console.WriteLine("Code: {0}", Codigo);
            Console.WriteLine("Name: {0}", Nombre);*/
            //En Ingles para diferenciar cual se ejecuta
            Console.WriteLine("Tasa de Interes Anual: {0}", TasaInteresAnual);
            Console.WriteLine("Saldo de ahorro: {0}", SaldoAhorro);   //ToString("F", CultureInfo.InvariantCulture));


        }
        public void UltimoInteresMensual()
        {
            //const int ano = 12;
            double Interes;

            Interes = SaldoAhorro * (TasaInteresAnual / ano);  //Como definir Ano como una constante para todo el proyecto? Donde?
            SaldoAhorro += Interes;
            MostrarInfo();
            Console.WriteLine("El interes calculado del ultimo mes fue de: {0}", Interes);   // ToString("F",CultureInfo.InvariantCulture));
            
        }

        public void ModificaTasaInteresAnual()
        {
            Console.WriteLine("Ingrese la nueva tasa de interes anual: ");

            try
            {
                double NuevaTasaInteresAnual = double.Parse(Console.ReadLine());
                TasaInteresAnual = NuevaTasaInteresAnual;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void ProyeccionSaldoAhorro(int CantidadMeses)
        {
            const int ano = 12;
            Console.WriteLine("\n     Informacion Actual");
            base.MostrarInfo();
            Console.WriteLine("Tasa de Interes Anual: {0}\n\n", TasaInteresAnual);       //ToString("F", CultureInfo.InvariantCulture));

            double TemporalSaldoAhorro = SaldoAhorro;

            Console.WriteLine("   Mes 1");
            Console.WriteLine("Saldo Ahorro: {0}\n", TemporalSaldoAhorro);                  //ToString("F", CultureInfo.InvariantCulture));

            for (int i = 1; i < CantidadMeses; i++)
            {
                TemporalSaldoAhorro += TemporalSaldoAhorro * (TasaInteresAnual / ano);
                Console.WriteLine("   Mes {0}", i + );
                Console.WriteLine("Saldo Ahorro: {0}\n", TemporalSaldoAhorro);             //ToString("F", CultureInfo.InvariantCulture 
            }
        }
    }
}
