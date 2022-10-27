using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise7
    {
		public static void run()
		{

        /*
        7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
            Dane testowe:
                25
                63
                79
            Rezultat w terminalu: 79 jest największa z podanych
        */

            // na dobra sprawe, to tutaj trzeba by bylo jeszcze napisac jakis "sprawdzacz", ktory by nie pozwolil do porownania dodawac stringi.
            // na razie nie wiem jak to zrobic, wiec moze pozniej do tego wroce :)

            Console.WriteLine("Exercise#7");
            Console.WriteLine("\nPodaj pierwsza liczbe");
            int val1 = 0;
            bool verification1 = Int32.TryParse(Console.ReadLine(), out val1);
            Console.WriteLine("Podaj druga liczbe");
            int val2 = 0;
            bool verification2 = Int32.TryParse(Console.ReadLine(), out val2);
            Console.WriteLine("Podaj trzecia liczbe");
            int val3 = 0;
            bool verification3 = Int32.TryParse(Console.ReadLine(), out val3);
            if (verification1 && verification2 && verification3)
            {
                if (val1 == val2 && val1 == val3 && val2 == val3)
                {
                    Console.WriteLine("Wszystkie wartosci sa rowne");
                }
                else if (val1 > val2 && val1 > val3)
                {
                    Console.WriteLine($"{val1} jest najwieksza");
                }
                else if (val2 > val3)
                {
                    Console.WriteLine($"{val2} jest najwieksza");
                }
                else
                {
                    Console.WriteLine($"{val3} jest najwieksza");
                }
            }
            else
            {
                Console.WriteLine("Podales niepoprawna wartosc. Prosze podac wartosci liczbowe.");
            }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();

        }

    }
}
