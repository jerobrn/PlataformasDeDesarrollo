using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int fecha = IngresoFecha();
            if(CalculoBi(fecha))
            {

                Console.WriteLine("Es año bisiesto");
            }
            else
            {
                Console.WriteLine("No es año bisiesto");
            }





        }


        static int IngresoFecha()
        {

            Console.WriteLine("ingrese año de nacimiento");
            string valor = Console.ReadLine();
            int fecha = int.Parse(valor);
            return fecha;
        }


        static Boolean CalculoBi(int fecha)
        {
            if(fecha%4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
/*
 armar un programa que le pida al usuario ingresar el año de la fecha de nacimiento y calcular si fue biciesto o no
encapsular en un metodo el ingreso de datos pasando el texto a mostrarle al usuario
y en otro metodo el calculo de si es biciesto devolviendo un valor booleano 
 
 */