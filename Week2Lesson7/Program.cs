using System;
using System.Drawing;
using System.Globalization;
using Week2Lesson7;

namespace Week2Lesson7
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Week2 Lesson7");
                Console.WriteLine("-------------");
                Console.Write("\nPodaj numer zadania ktore chcesz uruchomic lub '0' zeby przerwac\n\n" +
                    "1. Porownywanie dwoch zmiennych\n" +
                    "2. Sprawdzenie parzystosci\n" +
                    "3. Dodatnia czy ujemna\n" +
                    "4. Rok przestepny czy nie\n" +
                    "5. Stanowiska polityczne\n" +
                    "6. Kryteria wzrostu\n" +
                    "7. Porownywanie trzech liczb\n" +
                    "8. Miejsce na studiach\n" +
                    "9. Temperatura\n" +
                    "10. Trojkat\n" +
                    "11. Ocena z liczby na slowo\n" +
                    "12. Dzien tygodnia\n" +
                    "13. Kalkulator\n" +
                    "\n\n");

                int operation = 0;
                Int32.TryParse(Console.ReadLine(), out operation);
                Console.Clear();

                switch (operation)
                {
                    case 0:
                        Console.Clear();
                        return;
                    case 1:
                        Exercise1.run();
                        break;
                    case 2:
                        Exercise2.run();
                        break;
                    case 3:
                        Exercise3.run();
                        break;
                    case 4:
                        Exercise4.run();
                        break;
                    case 5:
                        Exercise5.run();
                        break;
                    case 6:
                        Exercise6.run();
                        break;
                    case 7:
                        Exercise7.run();
                        break;
                    case 8:
                        Exercise8.run();
                        break;
                    case 9:
                        Exercise9.run();
                        break;
                    case 10:
                        Exercise10.run();
                        break;
                    case 11:
                        Exercise11.run();
                        break;
                    case 12:
                        Exercise12.run();
                        break;
                        break;
                    case 13:
                        Exercise13.run();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n\nPodales numer zadania {operation}");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Jest to niepoprawny numer zadania. Sproboj ponownie.\n");
                        Console.ResetColor();
                        break;
                }

            }
        }
    }
}