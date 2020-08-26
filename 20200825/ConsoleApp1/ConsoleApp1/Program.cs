using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int numero = 0;
            int intentos = 0;
            Console.WriteLine("ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            while (numero!=7 && intentos<4)
            
            {
                
                Console.WriteLine("ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
                intentos++;
            }

            

        }
    }
}
