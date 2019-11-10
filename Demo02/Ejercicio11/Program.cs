using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 11.	Que pida 2 horas de un mismo día en el formato: HHMMSS y luego imprima la diferencia 
             * de tiempo: 
                        Ejemplo: 
	 	                Entrada: 
 	 	                Hora de ingreso: 083020  	 	Hora de salida: 163019  	Salida: 
	 	 	            Trabajó: 7 horas con 59 minutos y 59 segundos 

             */

            Console.WriteLine("Ingrese hora de entrada : ");
            string texto1 = Console.ReadLine();
            int ingreso = Convert.ToInt32(texto1) ;

            int ing_ss = ingreso % 100;//20
            ingreso = (ingreso - ing_ss)/100;//

            int ing_mm = ingreso % 100;
            ingreso = (ingreso - ing_mm)/100;
            int ing_hh = ingreso;

            int total_ing_seg = ing_hh * 3600 + ing_mm * 60 + ing_ss;

            Console.WriteLine("Ingrese hora de salida : ");
            string texto2 = Console.ReadLine();
            int salida = Convert.ToInt32(texto2);

            int sal_ss = salida % 100;
            salida = (salida - sal_ss)/100;

            int sal_mm = salida % 100;
            salida = (salida - sal_mm)/100;
            int sal_hh = salida;


            int total_sal_seg = sal_hh * 3600 + sal_mm * 60 + sal_ss;

            //Tiempo Trabajado
            int seg = total_sal_seg - total_ing_seg;
            int hh, mm, ss;

            hh = seg / 3600;
            mm = (seg - hh * 3600)/60;
            ss = seg - (hh * 3600+mm*60);

            Console.WriteLine("Tiempo trabajado : " + hh + " horas, " + mm + " minutos " + ss + " segundos" );
            Console.ReadKey();
        }
    }
}
