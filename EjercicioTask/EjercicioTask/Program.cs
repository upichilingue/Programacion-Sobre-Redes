using System;
using System.Threading;

class Program
{
    static void Main()
    {
        
        Thread hilo1 = new Thread(Tarea1);
        Thread hilo2 = new Thread(Tarea2);
        Thread hilo3 = new Thread(Tarea3);

        hilo1.Start();
        hilo2.Start();
        hilo3.Start();

        
        hilo1.Join();
        hilo2.Join();
        hilo3.Join();

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static void Tarea1()
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Hilo 1 - Vuelta " + i);
            Thread.Sleep(1000); 
        }
    }

    static void Tarea2()
    {
        for (int i = 1; i <= 1; i++)
        {
            Console.WriteLine("Hilo 2 - Vuelta " + i);
            Thread.Sleep(2000); 
        }
    }

    static void Tarea3()
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("Hilo 3 - Vuelta " + i);
            Thread.Sleep(1500); 
        }
    }
}