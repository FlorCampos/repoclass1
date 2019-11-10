using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre: ");
            string n = Console.ReadLine(); // todo lo que se ingrese con read serà siempre un texto.
            //readkey lee solo una tecla
            //readline lee todo loq ue se haya ingresado hasta donde està el cursor
            Console.WriteLine("Hola " + n + ", bienvenido a C Sharp");
            Console.ReadKey();

        }
    }
}
