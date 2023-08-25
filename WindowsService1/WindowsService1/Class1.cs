using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService1
{
    class Class1
    {

        static void Main(string[] args)
        {

            // Crear una instancia del servicio
            IncrementService service = new IncrementService();

            // Ejecutar el servicio
            ServiceBase.Run(service);

        }

    }
}
