using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, y = 0, rez = 0;
            char promenljiva = 'x';
            string operacija = "";

            Console.WriteLine("Unesite vrednost promenljivih:");
            try
            {
                Console.Write("x = ");
                x = Convert.ToDouble((Console.ReadLine()).Replace(",", "."));

                promenljiva = 'y';
                Console.Write("y = ");
                y = Convert.ToDouble((Console.ReadLine()).Replace(",", "."));
            }
            catch
            {
                Console.Write("Neispravan unos! Promenljiva {0} mora biti validan brojcani podatak!", promenljiva);
                Console.ReadKey();
                System.Environment.Exit(1);
            }

            Console.Write("Unesite operaciju: ");
            operacija = Console.ReadLine();

            switch (operacija)
            {
                case "+":
                    rez = x + y;
                    break;
                case "-":
                    rez = x - y;
                    break;
                case "*":
                    rez = x * y;
                    break;
                case "/":
                    rez = x / y;
                    break;
                default:
                    Console.WriteLine("Uneta operacija '{0}' nije validna!", operacija);
                    Console.ReadKey();
                    System.Environment.Exit(1);
                    break;
            }

            Console.WriteLine("Rezultat je:  rez = {0} {1} {2} = {3}", x, operacija, y, rez);
            Console.ReadKey();

        }
    }
}
