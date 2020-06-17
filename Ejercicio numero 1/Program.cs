using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_numero_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
               // Crear una aplicacion que muestre la tabla de multiplicar del(7), tips usar ciclo while.

                int tabla = 7;
                int contador = 0;
               int  result;
               
                
                while (contador <= 9)
                {
                    contador++;

                    result = contador * tabla;

                    Console.WriteLine(contador + " X " + tabla + " = " + result);

                   
                }             
                Console.ReadKey();
            }
        }
    }
    }

