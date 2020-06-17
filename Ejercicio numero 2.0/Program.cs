using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_numero_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Crear una aplicacion que le pida al usuario un numero positivo y el sistema identifique si es primo o no.

         
            Console.WriteLine("Ingrese un numero mayor que 1");
           int  num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Le he pedido mayor que uno");
                Console.ReadKey();
            }

            int contador = 0;

            for (int i = 1; i <= num; i++)
            {

                int Conv = num % i;



                if (Conv == 0)
                {
                    contador = contador + 1;
                }

                if (contador > 2)
                {
                    Console.WriteLine("NO es primo");

                    Console.ReadKey();
                }

                if (num == i && contador <= 2)
                {


                    Console.WriteLine("Es primo");
                    
                    Console.ReadKey();

                }
            }
        }
    }
}
