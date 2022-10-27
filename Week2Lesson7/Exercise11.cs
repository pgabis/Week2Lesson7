using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise11
    {
        public static void run()
        {
            /*
            11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
                Ocena Opis
                6 Celujący
                5 Bardzo dobry
                4 Dobry
                3 Dostateczny
                2 Dopuszczający
                1 Niedostateczny
                    Dane testowe: 3
                    Rezultat w terminalu: Dostateczny
            */

            Console.WriteLine("Exercise#11");
            Console.WriteLine("\nPodaj ocene ucznia");
            int rate = 0;
            bool verification = Int32.TryParse(Console.ReadLine(), out rate);
            if (verification)
            {
                switch (rate)
                {
                    case 1:
                        Console.WriteLine("Niedostateczny");
                        break;
                    case 2:
                        Console.WriteLine("Dopuszczający");
                        break;
                    case 3:
                        Console.WriteLine("Dostateczny");
                        break;
                    case 4:
                        Console.WriteLine("Dobry");
                        break;
                    case 5:
                        Console.WriteLine("Bardzo dobry");
                        break;
                    case 6:
                        Console.WriteLine("Celujący");
                        break;
                    default:
                        Console.WriteLine("Podana liczba nie spelnia kriterii oceny w rozumieniu szkolnictwa :)");
                        break;
                }
            }
            else
                Console.WriteLine("Podana wartosc musi byc liczba");

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }

     }
}

