using System;

namespace APP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secreto = random.Next(10);

            int num = 0;
            for (int i=0; i<3;i++)
            {

                num = Inicio("ingrese un numero");


                if (secreto == num)
                {
                    
                    break;
                }
  
            }
            
            
            if(secreto == num)
            {
                Ganaste();

            }
            else
            {
                Perdiste(secreto);
            }

 



        }



        static void Ganaste()
        {
            Console.WriteLine("Ganaste!");
        }
        static void Perdiste(int valor)
        {
            Console.WriteLine("perdiste, el número era: " + valor);
        }

        static int Inicio(string mensaje)
        {
            Console.WriteLine("ingrese un numero: ");
            string ingreso = Console.ReadLine();
            int num = int.Parse(ingreso);
            return num;

        }

    }
}
