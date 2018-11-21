using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionCSharp
{
    class Cliente : IComun
    {
        protected string Codigo;
        protected string Nombre;

        public Cliente(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public void MostrarInfo()   //El metodo debe ser Public ya que se implemente de la Interface
        {
            Console.WriteLine("Codigo: {0}", Codigo);
            Console.WriteLine("Nombre: {0}", Nombre);
        }
    }
}
