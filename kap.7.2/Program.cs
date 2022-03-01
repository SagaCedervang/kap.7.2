using System;
using System.Collections.Generic;

namespace kap._7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 7.6
            double[] tal = new double[3];
            tal[0] = 4;
            tal[1] = 1.5;
            tal[2] = 2.5;
            double summa = Addera(tal);
            Console.WriteLine($"Summan av talen är {summa}");
        }

        static double Addera(double[] tal)
        {
            double talAdd = 0;
            for (int i = 0; i < tal.Length; i++)
            {
                talAdd += tal[i];
            }
            return talAdd;
            */
            /* 7.7
            List<double> talList = new List<double>();

            Console.WriteLine("Vilka tal vill du ha i listan, skriv 0 när du är klar.");
            string add = Console.ReadLine();
            while (add != "0")
            {
                talList.Add(double.Parse(add));
                add = Console.ReadLine();
            }
            Console.WriteLine($"\nhär är talen i listan:");
            foreach (double tal in talList)
            {
                Console.WriteLine(tal);
            }

            double medelvärde = Medelvärde(talList);
            Console.WriteLine("\n" + medelvärde);

        }

        static double Medelvärde(List<double> talList)
        {
            double talAdd = 0;
            int antal = 0;
            for (int i = 0; i < talList.Count; i++)
            {
                talAdd += talList[i];
                antal++;
            }

            double medelvärde = talAdd / antal;
            return medelvärde;
            */


        }
        
    }
}
