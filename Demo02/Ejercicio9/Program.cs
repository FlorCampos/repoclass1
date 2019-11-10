using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             9.	Que solicite un valor que represente la cantidad de segundos, luego que se imprima la cantidad de horas, minutos y segundos se tiene. 
             Ejemplo:  
                    Entrada:  
                    Cantidad de segundos: 10000 
                    Salida:  
             Hay 2 horas con 46 minutos y 40 segundos 

             */

            Console.Write("Ingrese la cantidad de segundos : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int h, m, s;

            h = num / 3600;
            m = (num - h * 3600)/60;
            s = num - h * 3600 - m * 60;
            
            Console.Write("Hay " + h + " horas " + m +" minutos y " + s + " segundos");
            Console.ReadKey();
        }
    }
}
