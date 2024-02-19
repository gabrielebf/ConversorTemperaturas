using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
            Console.Write("Insira a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------");

            //F = (c * 9 / 5) + 32
            f = (c * 9 / 5) + 32;

            //K = c + 273,15
            k = c + 273.15;

            Console.WriteLine(c + " graus Celsius = " + f + " graus em Fahrenheit");
            Console.WriteLine(c + " graus Celsius = " + k + " graus em Kelvin");
            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
    }
}
