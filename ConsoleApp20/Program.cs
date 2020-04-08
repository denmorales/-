using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using MvcContrib.UI.DataList;

namespace ConsoleApp20
{
    class Program
    {
        

        static void Main(string[] args)
        {

            StreamWriter go = new StreamWriter(@"C:\Games\TEXT.txt");

            string[] massA = {"Аргентина","Бельгия","Бразилия","Испания","Хорватия","Германия","Франция","Англия",
            };
            string[] massB = {"Уругвай", "Россия","Италия","Чили","Швейцария","Голландия","Португалия","Колумбия"
            };
            string[] massC = {"Уэльс","КотДивуар","Австрия","Польша","Чехия","Турция","США","Мексика"
            };
            string[] massD = {"Австралия","Египет","Греция","Исландия","Ирландия","Дания","Швеция","Шотландия"
            };
            Random rand = new Random(Environment.TickCount);


            var unsorted = massA.ToList();


            var sortedA = new List<string>();
            while (unsorted.Count > 0)
            {
                int indexToRemove = rand.Next(unsorted.Count);
                string country = unsorted[indexToRemove];
                sortedA.Add(country);
                unsorted.Remove(country);
            }

            var unsorted2 = massB.ToList();


            var sortedB = new List<string>();
            while (unsorted2.Count > 0)
            {
                int indexToRemove = rand.Next(unsorted2.Count);
                string country = unsorted2[indexToRemove];
                sortedB.Add(country);
                unsorted2.Remove(country);
            }

            var unsorted3 = massC.ToList();


            var sortedC = new List<string>();
            while (unsorted3.Count > 0)
            {
                int indexToRemove = rand.Next(unsorted3.Count);
                string country = unsorted3[indexToRemove];
                sortedC.Add(country);
                unsorted3.Remove(country);
            }



            var unsorted4 = massD.ToList();


            var sortedD = new List<string>();
            while (unsorted4.Count > 0)
            {
                int indexToRemove = rand.Next(unsorted4.Count);
                string country = unsorted4[indexToRemove];
                sortedD.Add(country);
                unsorted4.Remove(country);
            }

            var sortedEND = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                sortedEND.Add(sortedA[i]);
                sortedEND.Add(sortedB[i]);
                sortedEND.Add(sortedC[i]);
                sortedEND.Add(sortedD[i]);

            }

            int count3 = 0;
            foreach (string value in sortedEND)
            {
                go.WriteLine(value);
                count3++;
                if (count3 % 4 == 0)
                {
                    go.WriteLine();
                }

            }
            
            
            
            go.Close();
            







        }
    }
}
