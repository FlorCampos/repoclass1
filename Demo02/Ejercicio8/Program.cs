using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.	Que pida 3 notas y muestre el promedio.  

            double suma;

            Console.WriteLine("Ingrese nota 1 : ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese nota 2 : ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese nota 3 : ");
            int nota3 = Convert.ToInt32(Console.ReadLine());


            suma = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio es : " + suma);
            Console.ReadKey();
        }
    }
}
