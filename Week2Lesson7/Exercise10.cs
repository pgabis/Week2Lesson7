using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise10
    {
        public static void run()
        {
            /*
            10. Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
                Dane testowe: 40 55 65
                Rezultat w terminalu: Można zbudować trójkąt
            */

            Console.WriteLine("Exercise#10");
            Console.WriteLine("\nPodaj pierwsza liczbe");
            int side1 = 0;
            bool verification1 = Int32.TryParse(Console.ReadLine(), out side1);
            Console.WriteLine("Podaj druga liczbe");
            int side2 = 0;
            bool verification2 = Int32.TryParse(Console.ReadLine(), out side2);
            Console.WriteLine("Podaj trzecia liczbe");
            int side3 = 0;
            bool verification3 = Int32.TryParse(Console.ReadLine(), out side3);
            if (verification1 && verification2 && verification3)
            {
                if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                    Console.WriteLine("Podana wartosc musi byc wieksza od zera");
                else if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
                    Console.WriteLine("Można zbudować trójkąt");
                else
                    Console.WriteLine("Nieda sie zbudowac trojkata");
            }
            else
                Console.WriteLine("Podane wartosci musza byc liczbami");

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }   
}
