using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03
{
    class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, sum;
            Console.Write("Valor 1 : ");
            string s1 = Console.ReadLine();
            v1 = Convert.ToDouble(s1);

            Console.Write("Valor 2: ");
            string s2 = Console.ReadLine();
            v2 = Convert.ToDouble(s2);

            sum = v1 + v2;

            Console.Write("\n\n\tLa suma es: " + sum);
            Console.ReadKey();

            //Double con mayusculas---clase-- es del .net framework
            //double con minusculas---tipo de dato --variable primitiva del mismo csharp

        }
    }
}
