using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise3
    {
        public static void run()
        {
            /*
                3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
                    Dane testowe: 14
                    Rezultat w terminalu: 14 jest liczbą dodatnią
            */

            Console.WriteLine("Exercise#3");
            Console.WriteLine("\nPodaj liczbe aby sprawdzic czy jest dodatnia czy ujemna:");
            int enteredNumber = 0;
            Int32.TryParse(Console.ReadLine(), out enteredNumber);
            if (enteredNumber > 0)
                {
                    Console.WriteLine($"{enteredNumber} jest liczbą dodatnią");
                }
                else if (enteredNumber< 0)
                {
                    Console.WriteLine($"{enteredNumber} jest liczbą ujemną");
                }
                else
                {
                    Console.WriteLine($"{enteredNumber} nie jest liczbą ani dodatnią ani ujemną");
                }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
