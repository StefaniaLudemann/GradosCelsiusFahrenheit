using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradosCelsius_Fahrenheit
{
    class Program
    {
        //Utilizando como ingreso Grados Celsius, determine, previo calculo de la temperatura a grados Fahrenheit 
        //determine que deporte es el mas apropiado para la temperatura reinante.

        static void Main(string[] args)
        {
            double gradosCelsius = 0;
            double gradosFahr = 0;

            Console.WriteLine("por favor ingrese en grados Celsius para convertir a Fahrenheit: ");
            gradosCelsius = double.Parse(Console.ReadLine());

            gradosFahr = (gradosCelsius * 1.8) + 32;

            if(gradosFahr>85)
            {
                Console.WriteLine("usted puede practicar NATACION con " + gradosFahr + " grados Fahrenheit");
            }else if (gradosFahr> 70 && gradosFahr<=85)
            {
                Console.WriteLine("usted puede practicar TENIS con " + gradosFahr + " grados Fahrenheit");
            }else if (gradosFahr>35 && gradosFahr<=75)
            {
                Console.WriteLine("usted puede practicar GOLF con " + gradosFahr + " grados Fahrenheit");
            }else if(gradosFahr>32 && gradosFahr<=35)
            {
                Console.WriteLine("usted puede practicar ESQUI con " + gradosFahr + " grados Fahrenheit");
            }else if(gradosFahr<=32)
            {
                Console.WriteLine("sin info");
            }

            Console.ReadKey();
        }
    }
}
