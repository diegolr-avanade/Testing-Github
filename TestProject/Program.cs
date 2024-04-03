﻿using System;
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
            Console.WriteLine(" _____       _            _           _                 \r\n" +
                              "/  __ \\     | |          | |         | |                \r\n" +
                              "| /  \\/ __ _| | ___ _   _| | __ _  __| | ___  _ __ __ _ \r\n" +
                              "| |    / _` | |/ __| | | | |/ _` |/ _` |/ _ \\| '__/ _` |\r\n" +
                              "| \\__/\\ (_| | | (__| |_| | | (_| | (_| | (_) | | | (_| |\r\n" +
                              " \\____/\\__,_|_|\\___|\\__,_|_|\\__,_|\\__,_|\\___/|_|  \\__,_|\r\n                                                        \r\n                                                        ");

            double a, b;
            char op;

            // Primer dígito
            Console.WriteLine("Escribe el primer dígito:");
            a = Double.Parse(Console.ReadLine());

            // Segundo dígito
            Console.WriteLine("Escribe el segundo dígito:");
            b = Double.Parse(Console.ReadLine());

            // Operador
            Console.WriteLine("Escribe el operador (+,-,*,/):");
            op = Char.Parse(Console.ReadLine());

            // Resultado
            double resultado = Calculate(a, b, op);
            Console.WriteLine($"\n{a} {op} {b} = {resultado}");

            WaitForInput();
        }

        static void WaitForInput()
        {
            Console.WriteLine("\nPrograma terminado.\nPulse una tecla para cerrar...");
            Console.ReadLine();
        }

        static double Calculate(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    return 0;
            }
        }
    }
}
