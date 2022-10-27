using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise5
    {
        public static void run()
        {
            /*
            5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.
                Dane testowe: 21
                Rezultat w terminalu: Możesz zostać posłem
            posel - 21
            senator - 30
            premier - nie znalazlem wiec zalozmy 32 :)
            prezydent - 35
            */

            Console.WriteLine("Exercise#5");
            Console.WriteLine("\nPodaj wiek kandydata:");
            int enteredAge = 0;
            Int32.TryParse(Console.ReadLine(), out enteredAge);
            string a = "poslem";
            string b = "senatorem";
            string c = "premierem";
            string d = "prezydentem";
            if (enteredAge > 0)
            {
                {
                    if (enteredAge >= 35)
                    {
                        Console.WriteLine($"Mozesz zostac {a}, {b}, {c} albo {d}");
                    }
                    else if (enteredAge >= 32)
                    {
                        Console.WriteLine($"Mozesz zostac {a}, {b} lub {c}");
                    }
                    else if (enteredAge >= 30)
                    {
                        Console.WriteLine($"Mozesz zostac {a} lub {b}");
                    }
                    else if (enteredAge >= 21)
                    {
                        Console.WriteLine($"Mozesz zostac {a}");
                    }
                    else
                    {
                        Console.WriteLine("Nie uzyskales wieku minimalnego do objecia zadnej posady");
                    }
                }
            }
            else
            {
                Console.WriteLine("Podana wartosc nie moze byc mniejsza lub rowna '0'");
            }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
