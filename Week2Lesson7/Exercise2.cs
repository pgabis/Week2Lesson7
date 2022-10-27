using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise2
    {
        public static void run()
        {
            /*
            2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
                Dane testowe: 15
                Rezultat w terminalu: 15 jest liczbą nieparzystą
            */

            Console.WriteLine("Exercise#2");
            Console.WriteLine("\nPodaj liczbe by sprawdzic parzystosc:");
            int enteredParity = 0;
            Int32.TryParse(Console.ReadLine(), out enteredParity);
            if (enteredParity % 2 == 0)
                {
                    Console.WriteLine($"{enteredParity} jest liczbą parzystą");
                }
                else
                {
                    Console.WriteLine($"{enteredParity} jest liczbą nieparzystą");
                }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
