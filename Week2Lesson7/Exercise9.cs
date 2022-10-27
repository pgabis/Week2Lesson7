using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    internal class Exercise9
    {
        public static void run()
        {
            /*
            9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
                Temp < 0 – cholernie piździ
                Temp 0 – 10 – zimno
                Temp 10 – 20 – chłodno
                Temp 20 – 30 – w sam raz
                Temp 30 – 40 – zaczyna być słabo, bo gorąco
                Temp >= 40 – a weź wyprowadzam się na Alaskę.
                    Dane testowe: 41
                    Rezultat w terminalu: a weź wyprowadzam się na Alaskę.
            */

            Console.WriteLine("Exercise#9");
            Console.WriteLine("\nPodaj temperature");
            int temperature = 0;
            bool verification = Int32.TryParse(Console.ReadLine(), out temperature);
            if (verification)
            {
                if (temperature < 0)
                {
                    Console.WriteLine("Cholernie piździ");
                }
                else if ((temperature >= 0) && (temperature < 10))
                {
                    Console.WriteLine("Zimno");
                }
                else if ((temperature >= 10) && (temperature < 20))
                {
                    Console.WriteLine("Chlodno");
                }
                else if ((temperature >= 20) && (temperature < 30))
                {
                    Console.WriteLine("W sam raz");
                }
                else if ((temperature >= 30) && (temperature < 40))
                {
                    Console.WriteLine("Zaczyna być słabo, bo gorąco");
                }
                else 
                {
                    Console.WriteLine("A weź wyprowadzam się na Alaskę");
                }
            }
            else
            {
                Console.WriteLine("Podales niepoprawna wartosc");
            }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
            {

            }
        }
    }
}
