using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Valor entero de 3 dìgitos");
            int num = Convert.ToInt32(Console.ReadLine());

            int d1 = num % 10;
            int d2 = num / 10 % 10;
            int d3 = num / 100;

            Console.WriteLine("Resultado: " + d1 + "" + d2 + "" + d3);
            Console.ReadKey(); //preguntar
        }
    }
}
