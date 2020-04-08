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

                /*int name = i;
                switch (name)
                {
                    case 0:
                        sortedEND.Add("A");
                        break;
                    case 1:
                        sortedEND.Add("B");
                        break;
                    case 2:
                        sortedEND.Add("C");
                        break;
                    case 3:
                        sortedEND.Add("D");
                        break;
                    case 4:
                        sortedEND.Add("E");
                        break;
                    case 5:
                        sortedEND.Add("F");
                        break;
                    case 6:
                        sortedEND.Add("G");
                        break;
                    case 7:
                        sortedEND.Add("H");
                        break;
                    default:
                        sortedEND.Add("no");
                        break;




                }
                */
                sortedEND.Add(sortedA[i]);
                sortedEND.Add(sortedB[i]);
                sortedEND.Add(sortedC[i]);
                sortedEND.Add(sortedD[i]);

            }




            int count3 = 0; //запись в файл
            foreach (string value in sortedEND)
            {
                go.WriteLine(value);
                count3++;


            }
            go.Close();
            var newList = new List<string>();
            StreamReader back = new StreamReader(@"C:\Games\TEXT.txt");
            while (!back.EndOfStream) //запись из файла
            {
                newList.Add(back.ReadLine());
            }
            int count5 = 0;
            foreach (string value in newList)
            {
                Console.WriteLine(value);
                count5++;
                if (count5 % 4 == 0)
                {
                    Console.WriteLine();


                }

            }
            Console.WriteLine("введите первую страну");
            string TeamOne = Console.ReadLine();
            int countstr = 0;
            int nomer = 0;
            for (int k = 0; k < newList.Count; k++)
            {
                if (newList[k] == TeamOne)
                {
                    nomer = k;
                    countstr++;
                    break;
                }



            }
            bool flag = false;

            if (countstr != 0)
            {
                
                Console.WriteLine("введите вторую страну");
                string Team2 = Console.ReadLine();
                for (int l = 0; l < newList.Count; l++)
                {
                    if (newList[l] == Team2 && (l / 5 == nomer / 5))
                    {



                        flag = true;
                        Console.WriteLine("Такая команда есть и она в группе");



                    }





                }
                if (flag == false){
                    Console.WriteLine("Такая команда есть, но  она не в группе");

                }




            }
            else Console.WriteLine("ошибка, неправильная первая команда");













        }
    }
}
