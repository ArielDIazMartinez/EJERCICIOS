using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_numero_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que me diga la cantidad de digitos que tiene un numero positivo. Mostrar en mensaje ej: El numero ingresado tiene (N) digitos.

            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());

            int cont = 1;
            int mult = 10;

            while (mult <= num)
            {
                cont = cont + 1;
                mult = mult * 10;

                
            }
            Console.WriteLine("La cantidad de digitos del numero  " + num + " es " + cont);
            Console.ReadKey();

        }
    }
}
