using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise4
    {

        public static void run()
        {
            /*
                4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
                    Dane testowe: 2016
                    Rezultat w terminalu: 2016 jest rokiem przestępnym
            */

            Console.WriteLine("Exercise#4");
            Console.WriteLine("\nPodaj rok by sprawdzic czy jest przestepny:");
            int enteredYear = 0;
            Int32.TryParse(Console.ReadLine(), out enteredYear);
            if (enteredYear % 4 == 0)
                {
                    if (enteredYear % 400 == 0)
                    {
                        Console.WriteLine($"{enteredYear} jest rokiem przestępnym");
                    }
                    else if (enteredYear % 100 == 0)
                    {
                        Console.WriteLine($"{enteredYear} nie jest rokiem przestępnym");
                    }
                    else
                    {
                        Console.WriteLine($"{enteredYear} jest rokiem przestępnym");
                    }
                }
                else
                {
                    Console.WriteLine($"{enteredYear} nie jest rokiem przestępnym");
                }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
