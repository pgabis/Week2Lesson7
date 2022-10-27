using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise13
    {
        public static void run()
        {
            /*
            13.Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem
                Podaj pierwszą liczbę:
                …
                Podaj drugą liczbę:
                …
                Podaj numer operacji do wykonania:
                1.Dodawanie
                2.Odejmowanie
                3.Mnożenie
                4.Dzielenie
                …
                Twój wynik to:
            */
            Console.WriteLine("Exercise#13");
            Console.WriteLine("\nPodaj pierwsza liczbe");
            float value1 = 0;
            bool verification1 = float.TryParse(Console.ReadLine(), out value1);
            Console.WriteLine("Podaj pierwsza liczbe");
            float value2 = 0;
            bool verification2 = float.TryParse(Console.ReadLine(), out value2);
            if (verification1 && verification2)
            {
                Console.Write("\nPodaj numer operacji do wykonania:\n" +
                "1. Dodawanie\n" +
                "2. Odejmowanie\n" +
                "3. Mnożenie\n" +
                "4. Dzielenie\n" +
                "\r\n");
                var operation = Console.ReadKey();

                switch (operation.KeyChar)
                {
                    case '1':
                        Console.WriteLine($"\nTwój wynik to: {value1 + value2}");
                        break;
                    case '2':
                        Console.WriteLine($"\nTwój wynik to: {value1 - value2}");
                        break;
                    case '3':
                        Console.WriteLine($"\nTwój wynik to: {value1 * value2}");
                        break;
                    case '4':
                        if (value2 != 0)
                        {
                            Console.WriteLine($"\nTwój wynik to: {value1 / value2}");
                        }
                        else
                            Console.WriteLine("\nDzielenie na '0' grozi kara grzywny lub pozbawienia wolnosci");
                        break;
                    default:
                        Console.WriteLine("\nNie wiem ktora dokladnie operacje chciales wykonac, ale cos Ci sie nie udalo. Sproboj ponownie");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\n\nChlopie, co Ty wyprawiasz? Mialy byc liczby!");
            }

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
