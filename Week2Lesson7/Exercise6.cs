using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise6
    {
        public static void run()
        {
            /*
            6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
                Dane testowe: 140
                Rezultat w terminalu: Jesteś krasnoludem
            */

            Console.WriteLine("Exercise#6");
            Console.WriteLine("\nPodaj wzrost w centymetrach");
            Byte height = 0;
            Byte.TryParse(Console.ReadLine(), out height);
                if (height > 0 && height <= 140)
                {
                    Console.WriteLine("Jestes krasnoludem");
                }
                else if (height > 140 && height <= 160)
                {
                    Console.WriteLine("Jestes ciut wiekszy od krasnoluda");
                }
                else if (height > 160 && height <= 190)
                {
                    Console.WriteLine("Jestes przecietnego wzrostu");
                }
                else if (height > 190)
                {
                    Console.WriteLine("Jestes zyrafa");
                }
                else
                {
                    Console.WriteLine("Wzrost nie moze byc '0' lub liczba ujemna");
                }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
