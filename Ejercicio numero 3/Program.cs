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
            /* Crear una aplicacion que genere un numero aleatorio entre 50 y 100.Y pida al usuario si desea generar otro numero
                 antes de terminar la aplicacion.El programa debe terminar cuando el usuario presione la letra 'S'  */


            string parar;
            int num1;



           do
           {              
                Random r = new Random();
                num1 = r.Next(50, 101);

                Console.WriteLine("Generando numero aleatorio " + "=" + num1);
                Console.WriteLine("presione la tecla S para parar");
                parar = Console.ReadLine();

            } while (parar == "s" );
            {

                Console.WriteLine("bye bye bye bye bye bye bye bye bye bye");
            
            }
            Console.ReadKey();


        }
    }
}
