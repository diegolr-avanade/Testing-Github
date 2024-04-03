using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<---Calculadora--->");

            double a, b;
            char op;

            Console.WriteLine("Inserte el primer dígito:");
            a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Inserte el segundo dígito:");
            b = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Tus numeros son: {a} y {b}");
            WaitForInput();
        }

        static void WaitForInput()
        {
            Console.WriteLine("\nPrograma terminado,\npulse una tecla para cerrar...");
            Console.ReadLine();
        }
    }
}
