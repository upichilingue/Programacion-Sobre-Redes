using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoWebService2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            soap.CountryInfoService client = new soap.CountryInfoService();

            var respuesta = client.FullCountryInfoAllCountries();

            Console.WriteLine(respuesta.FirstOrDefault().sContinentCode);
            Console.WriteLine(respuesta.FirstOrDefault().sName);
            Console.WriteLine(respuesta.FirstOrDefault().sCapitalCity);
            Console.WriteLine(respuesta.FirstOrDefault().sCountryFlag);
            Console.WriteLine(respuesta.FirstOrDefault().sISOCode);

            Console.Read();

        }
    }
}
