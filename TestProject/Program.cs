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

            Console.WriteLine("Escribe el primer dígito:");
            a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el segundo dígito:");
            b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el operador (+,-,*,/):");
            op = Char.Parse(Console.ReadLine());

            Console.WriteLine($"Los numeros son: {a} y {b}");
            Console.WriteLine($"El operador elegido es: {op}");
            WaitForInput();
        }

        static void WaitForInput()
        {
            Console.WriteLine("\nPrograma terminado.\nPulse una tecla para cerrar...");
            Console.ReadLine();
        }
    }
}
