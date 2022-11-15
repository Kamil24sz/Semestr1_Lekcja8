using System;
using System.Threading;

namespace Ćwiczenie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj Łowco, na jakiego potwora polujesz?");

            string potwor = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"{potwor} mówisz... Niech pomyślę...");
            Thread.Sleep(3000);
            Console.Clear();
            // Gryf =>  gryf       GRYF =>   gryf     grYF  =>  gryf
            switch (potwor.ToLower())
            {
                case "gryf":
                    Console.WriteLine("Gryf z wyglądu jest połączeniem lwa (ogon i");
                    Console.WriteLine("sierść) oraz orła(ostry, zakrzywiony dziób, pazury i ogromne skrzydła)");
                    Console.WriteLine("HP: 1000");
                    Console.WriteLine("Szybkość: 80");
                    break;

                case "bies":
                    Console.WriteLine("W oczach przeciętnego mieszkańca Królestw Północy");
                    Console.WriteLine("bies jest ucieleśnieniem wszystkiego co złe i diabelskie,"); 
                    Console.WriteLine("co możnazresztą zauważyć w wielu znanych porzekadłach.");
                    Console.WriteLine("HP: 5000");
                    Console.WriteLine("Szybkość: 90");
                    break;

                default:
                    Console.WriteLine("Takiego potwora to ja nie znam");
                    break;
            }

            Console.ReadLine();
        }
    }
}
