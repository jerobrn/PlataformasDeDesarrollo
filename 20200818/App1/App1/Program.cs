using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ejercicio 1");

            //int dado;
            //string mensaje;
            //Console.WriteLine("ingresá un número del 1 al 6");
            //string ingreso = Console.ReadLine();
            //dado = int.Parse(ingreso);


            //if(dado==1)
            //{
            //     mensaje = "Ingresaste el número 1: Ganaste 100 pesos";

            //}
            //else if(dado == 2 || dado==3)
            //{
            //     mensaje = $"Ingresaste el número {dado}: Ganaste 1000 pesos";

            //}
            //else if(dado >3 && dado <=6)
            //{
            //     mensaje = "perdiste, volvé a intentar";

            //}
            //else
            //{
            //    mensaje = "Numero Equivocado solo se permiten de 1 a 6";
            //}
            //Console.WriteLine(mensaje);

            Console.WriteLine("Ejercicio 2");
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                if (suma >= 50)
                {
                    Console.WriteLine("llegaste a 50");
                    break;
                    
                }
           
            Console.WriteLine("ingresá un número");
            string ingreso = Console.ReadLine();
           
            suma += int.Parse(ingreso);

            }
            Console.WriteLine("llegaste a 10 numeros");
        }
    }
}
