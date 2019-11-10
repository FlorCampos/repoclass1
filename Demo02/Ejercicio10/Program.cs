using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10.	Que calcule y muestre el menor número de monedas de 5, 2 y 1 para 
             * desglosar una cantidad C, de Soles. Por ejemplo si C fuese 23, entonces 
             * la cantidad de monedas de 5 sería 4, de 2 sería 1 y de 1 sería 1. 
             */

            
            Console.Write("Ingrese cantidad : ");

            string num = Console.ReadLine();
            int cant = Convert.ToInt32(num);
            //int cant= Convert.ToInt32(Console.Read());

            int m5, m2, m1;

            m5 = cant / 5;
            m2 = (cant % 5)/2;
            m1 = cant - (m5*5+m2*2);

            Console.WriteLine("Moneda de 5: " + m5);
            Console.WriteLine("Moneda de 2: " + m2);
            Console.WriteLine("Moneda de 1: " + m1);
            Console.ReadKey();


        }
    }
}
