using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 123456;
            //Se imprima en orden invertido

            //int d1 = x % 10;
            //int d2 = x / 10 % 10;
            //int d3 = x / 100%10;
            //int d4 = x / 1000%10;
            //int d5 = x / 10000%10;
            //int d6 = x / 100000;

            //Console.WriteLine("Resultado: " + d1 + "" + d2 + "" + d3 + "" + d4 + "" + d5 + "" + d6);

            //Imprimir la suma de los tres primeros dìgitos con las suma de los 3 ùltimos dìgitos

            //int d1 = x / 1000;
            //int d2 = x % 1000;
            //int sum = d1 + d2;  
                       
            //Console.WriteLine("La suma es: " + sum );

            //sumar los pares de dìgitos(12 +34+56)
            Console.WriteLine("La suma es: " + (x/10000+x/100%100+ x%100) );
            Console.ReadKey();
        }
    }
}
