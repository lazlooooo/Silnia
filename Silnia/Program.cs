using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia
{
    class Program
    {
        static double Silnia(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else return n* Silnia(n - 1);

        }
        static void Main(string[] args)
        {
            int testy;
            //double silnia;
            testy= int.Parse(Console.ReadLine());
            for(int i=0; i < testy; i++)
            {
                Console.Write("Podaj podstawe silni");
                double liczba = double.Parse(Console.ReadLine());
               if (liczba < 10)
                 {
                     silnia = Silnia(liczba);
                     double jednosci = silnia % 10;
                 Console.Write("Cyfra dziesiątek:{0}",((silnia%100)- jednosci)/10);
                 Console.WriteLine(" jedności:{0}",jednosci);
                 }
                 else
                 {
                     Console.Write(0);
                     Console.WriteLine(" {0}",0);
                Console.WriteLine(Silnia(liczba));

                }
            }

        }
    }

