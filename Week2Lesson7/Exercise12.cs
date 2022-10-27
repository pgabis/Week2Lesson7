using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise12
    {
        public static void run()
        {
            /*
            12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
                Dane testowe: 4
                Rezultat w terminalu: Czwartek
            */

            Console.WriteLine("Exercise#12");
            Console.WriteLine("\nPodaj numer dnia tygodnia");
            int day = 0;
            Int32.TryParse(Console.ReadLine(), out day);

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Poniedzialek");
                        break;
                    case 2:
                        Console.WriteLine("Wtorek");
                        break;
                    case 3:
                        Console.WriteLine("Sroda");
                        break;
                    case 4:
                        Console.WriteLine("Czwartek");
                        break;
                    case 5:
                        Console.WriteLine("Piatek");
                        break;
                    case 6:
                        Console.WriteLine("Sobota");
                        break;
                    case 7:
                        Console.WriteLine("Niedziela");
                        break;
                    default:
                        Console.WriteLine("Tydzien ma tylko siedem dni, podaj poprawna liczbe");
                        break;
                }


            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
