﻿using System;

namespace Week2Lesson4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Week2 Lesson4");

            // Exercise#1
            /*  
                1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.
                    Dane testowe:
                    a: 5
                    b: 5
                    Rezultat w terminalu :
                    5 i 5 są równe
            */

            Console.WriteLine("");
            Console.WriteLine("Exercise#1");
            Console.WriteLine("Please enter 1st digit to compare:");
            string toComp1 = Console.ReadLine();
            int comp1 = 0;
            Int32.TryParse(toComp1, out comp1);
            Console.WriteLine("Please enter 2nd digit to compare:");
            string toComp2 = Console.ReadLine();
            int comp2 = 0;
            Int32.TryParse(toComp2, out comp2);
            if (comp1 == comp2)
            {
                Console.WriteLine($"{toComp1} i {toComp2} są równe");
            }
            else
            {
                Console.WriteLine($"{toComp1} i {toComp2} nie są równe");
            }


            /*
                2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
                    Dane testowe : 15
                    Rezultat w terminalu :
                    15 jest liczbą nieparzystą
            */

            Console.WriteLine("");
            Console.WriteLine("Exercise#2");
            Console.WriteLine("Please enter digit to check:");
            string readParity = Console.ReadLine();
            int enteredParity = 0;
            Int32.TryParse(readParity, out enteredParity);
            if (enteredParity % 2 == 0)
            {
                Console.WriteLine($"{readParity} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{readParity} jest liczbą nieparzystą");
            }


            /*
                3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
                    Dane testowe : 14
                    Rezultat w terminalu :
                    14 jest liczbą dodatnią
            */
            /*
            Console.WriteLine("");
            Console.WriteLine("Exercise#3");
            Console.WriteLine("Please enter number2 to check:");
            string readParity = Console.ReadLine();
            int enteredParity = 0;
            Int32.TryParse(readParity, out enteredParity);
            if (enteredParity % 2 == 0)
            {
                Console.WriteLine($"{readParity} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{readParity} jest liczbą nieparzystą");
            }
            */
            /*
            4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
            jest rokiem przestępnym.
            Dane testowe : 2016
            Rezultat w terminalu :
            2016 jest rokiem przestępnym
            5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
            uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,
            prezydenta.
            Dane testowe : 21
            Rezultat w terminalu :
            Możesz zostać posłem
            6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
            wymyśloną kategorię wzrostu.
            Dane testowe : 140
            Rezultat w terminalu :
            Jesteś krasnoludem
            7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
            która jest największa
            Dane testowe:
            25
            63
            79
            Rezultat w terminalu :
            79 jest największa z podanych
            8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
            na studiach wg. Następujących kryteriów:
            Wynik z Matury z matematyki powyżej 70
            Wynik z fizyki powyżej 55
            Wynik z chemii powyżej 45
            Łączny wynik z 3 przedmiotów powyżej 180
            Albo
            Wynik z matematyki i jednego przedmiotu powyżej 150
            Dane testowe:
            Matematyka 80
            Fizyka 71
            Chemia 0
            Rezultat w terminalu :
            Kandydat dopuszczony do rekrutacji
            9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w
            poniższych kryteriach
            Temp < 0 – cholernie piździ
            Temp 0 – 10 – zimno
            Temp 10 – 20 – chłodno
            Temp 20 – 30 – w sam raz
            Temp 30 – 40 – zaczyna być słabo, bo gorąco
            Temp >= 40 – a weź wyprowadzam się na Alaskę.
            Dane testowe : 41
            Rezultat w terminalu :
            a weź wyprowadzam się na Alaskę.
            10. Napisz program, który sprawdzi, czy z 3 podanych długości można
            stworzyć trójkąt
            Dane testowe : 40 55 65
            Rezultat w terminalu :
            Można zbudować trójkąt
            11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
            Ocena Opis
            6 Celujący
            5 Bardzo dobry
            4 Dobry
            3 Dostateczny
            2 Dopuszczający
            1 Niedostateczny
            Dane testowe : 3
            Rezultat w terminalu :
            Dostateczny
            12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
            nazwę
            Dane testowe : 4
            Rezultat w terminalu :
            Czwartek
            13.Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I
            będzie prostym kalkulatorem
            Podaj pierwszą liczbę:
            …
            Podaj drugą liczbę:
            …
            Podaj numer operacji do wykonania:
            1.Dodawanie
            2.Odejmowanie
            3.Mnożenie
            4.Dzielenie
            …
            Twój wynik to:

                        */

        }
    }
}