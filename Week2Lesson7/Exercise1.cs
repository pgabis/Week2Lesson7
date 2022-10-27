using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Lesson7;


namespace Week2Lesson7
{
    internal class Exercise1
    {
        public static void run()
        {
            /*
                1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
                    Dane testowe:
                    a: 5
                    b: 5
                    Rezultat w terminalu: 5 i 5 są równe
            */

            Console.WriteLine("Exercise#1");
            Console.WriteLine("\nPodaj pierwsza liczbe do porownywania:");
            int comp1 = 0;
            Int32.TryParse(Console.ReadLine(), out comp1);
            Console.WriteLine("Podaj druga liczbe do porownywania:");
            int comp2 = 0;
            Int32.TryParse(Console.ReadLine(), out comp2);
            if (comp1 == comp2)
            {
                Console.WriteLine($"{comp1} i {comp2} są równe");
            }
            else
            {
                Console.WriteLine($"{comp1} i {comp2} nie są równe");
            }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
            /*
            Console.WriteLine("Czy chcesz wykonac inne zadanie?\n1. TAK\n2. NIE ");
            int otherEx = 0;
            Int32.TryParse(Console.ReadLine(), out otherEx);
            if (otherEx == 1)
            {
                Program.();
            }
            else if (otherEx == 2)
            {
                return;
            }
            else 
            {
                Console.WriteLine("Podales niepoprawna wartosc");
            }
            */
        }
    }
}
