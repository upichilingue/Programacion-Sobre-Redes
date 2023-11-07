using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_SoapUI
{
    internal class Program
    {

        Soap1.TipoCambio client = new Soap1.TipoCambio();

        static void Main(string[] args)
        {

            Soap1.TipoCambio client = new Soap1.TipoCambio();

            var respuesta = client.TipoCambioDia();

            Console.WriteLine(respuesta.CambioDolar.First().fecha);
            Console.WriteLine(respuesta.CambioDolar.First().referencia);
            Console.ReadLine();

        }
    }
}
