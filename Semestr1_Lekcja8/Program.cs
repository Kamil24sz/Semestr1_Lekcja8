using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //program który tłumaczy cyfry na dni tygodnia słownie
            // 1 - poniedziałek
            // 2 - wtorek
            // ...  7 - niedziela

            Console.WriteLine("Podaj numer tygodnia (1-7):");
            int dzien = int.Parse(Console.ReadLine());

            if (dzien == 1)
            {
                Console.WriteLine("poniedziałek");
            }
            else if(dzien == 2)
            {
                Console.WriteLine("Wtorek");
            }
            else if (dzien == 3)
            {
                Console.WriteLine("Środa");
            }
            else if (dzien == 4)
            {
                Console.WriteLine("Czwartek");
            }
            else if (dzien == 5)
            {
                Console.WriteLine("Piątek");
            }
            else if (dzien == 6)
            {
                Console.WriteLine("Sobota");
            }
            else if (dzien == 7)
            {
                Console.WriteLine("Niedziela");
            }
            else
            {
                Console.WriteLine("Niepoprawna liczba");
            }

            //INSTRUKCJA SWITCH 

            switch (dzien)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;

                case 2:
                    Console.WriteLine("Wtorek");
                    break;

                case 3:
                    Console.WriteLine("Środa");
                    break;

                case 4:
                    Console.WriteLine("Czwartek");
                    break;

                case 5:
                    Console.WriteLine("Piątek");
                    break;

                case 6:
                    Console.WriteLine("Sobota");
                    break;

                case 7:
                    Console.WriteLine("Niedziela");
                    break;

                default:
                    Console.WriteLine("Niepoprawna liczba");
                    break;   
            }

            Console.WriteLine("Podaj ocenę w systemie amerykańskim");
            //A - 5,  B - 4, C - 3, D - 2, F - 1
            
            char ocena = Char.Parse(Console.ReadLine());

            switch (ocena)
            {
                case 'A':
                    Console.WriteLine("5 - bardzo dobry");
                    break;

                case 'B':
                    Console.WriteLine("4 - dobry");
                    break;

                case 'C':
                    Console.WriteLine("3 - dostateczny");
                    break;

                case 'D':
                    Console.WriteLine("2 - dopuszczający");
                    break;

                case 'F':
                    Console.WriteLine("1 - niedostateczny");
                    break;

                default :
                    Console.WriteLine("Podana wartość jest nieporawidłowa");
                    break;
            }

            Console.ReadLine();
        }
    }
}
