using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise8
    {
        public static void run()
        {
            /*
            8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:
                Wynik z Matury z matematyki powyżej 70
                Wynik z fizyki powyżej 55
                Wynik z chemii powyżej 45
                Łączny wynik z 3 przedmiotów powyżej 180
                    Albo
                Wynik z matematyki i jednego przedmiotu powyżej 150
                    Dane testowe:
                        Matematyka 80
                        Fizyka 71
                        Chemia 0
                    Rezultat w terminalu: Kandydat dopuszczony do rekrutacji
            */

            Console.WriteLine("Exercise#8");
            Console.WriteLine("\nPodaj wynik z Matury z matematyki");
            int mathResult = 0;
            Int32.TryParse(Console.ReadLine(), out mathResult);
            Console.WriteLine("Podaj wynik z Matury z fizyki");
            int physResult = 0;
            Int32.TryParse(Console.ReadLine(), out physResult);
            Console.WriteLine("Podaj wynik z Matury z chemii");
            int chemResult = 0;
            Int32.TryParse(Console.ReadLine(), out chemResult);
            if (mathResult > 70 && physResult > 55 && chemResult > 45 && mathResult + physResult + chemResult > 180 || mathResult + physResult > 150 || mathResult + chemResult > 150)
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat nie jest dopuszczony do rekrutacji");
            }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
