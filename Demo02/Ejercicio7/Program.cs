using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.Que solicite la temperatura en grados Celsius y la convierta a grados Fahrenheit 
            double c, f;
            Console.WriteLine("Ingrese la temperatura en grados celsius : ");
            
            c = Convert.ToDouble(Console.ReadLine());
            f = c * 9 / 5 + 32;

            Console.WriteLine("La temperatura en Farenheit es : " + f);
            Console.ReadKey();

        }
    }
}
