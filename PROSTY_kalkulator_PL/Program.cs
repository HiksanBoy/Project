using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROSTY_kalkulator_PL
{
    class Program
    {
        
        static void Main(string[] args)
            
        {
            int exit = 1;
            do
            {
                //Deklaracja zmiennych
                int liczba1, liczba2;
                

                //Pwitanie 
                Console.WriteLine("Witaj w prostym kalkulatorze :)");
                Console.WriteLine("#################################\n");

                //Zapytanie o "liczba1"
                Console.WriteLine("Wprowadź pierwszą liczbę i potwierdź wybór Enterem");
                liczba1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------");

                //Zapytanie o "liczba2"
                Console.WriteLine("\nWprowadź drugą liczbę i potwierdź wybór Enterem");
                liczba2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------");

                //Zapytanie o operaceje na liczbach
                Console.WriteLine("Wybierz operacje którą chcesz wykonać na wcześniej wybranych liczbach:\n");
                Console.WriteLine("\ta - dodawanie (+)\n \tb - odejmowanie (-)\n \tc - mnożenie(*)\n \td - dzielenie(/)\n \tclear - WYCZYŚĆ PAMIĘĆ \n");
                Console.WriteLine("Jaki jest twój wybór?");


                // Meny wyboru 
                switch (Console.ReadLine())
                {
                    case "a":

                        Console.WriteLine($"Twój wynik {liczba1} + {liczba2} = " + (liczba1 + liczba2));
                        break;
                    case "b":

                        Console.WriteLine($"Twój wynik {liczba1} - {liczba2} = " + (liczba1 - liczba2));
                        break;

                    case "c":

                        Console.WriteLine($"Twój wynik {liczba1} * {liczba2} = " + (liczba1 * liczba2));
                        break;

                    case "d":

                        Console.WriteLine($"Twój wynik {liczba1} / {liczba2} = " + (liczba1 / liczba2));
                        break;

                    case "clear":
                        Console.WriteLine("Kasowanie" + (exit = 0));
                        Console.Clear();
                        break;
                        
                                               
                }
            } while (exit < 1);





            //Zakończenie 
            Console.WriteLine("\n\nAby zakończyć program naciśnij dowolny ");








            Console.ReadKey();

        }
    }
}
