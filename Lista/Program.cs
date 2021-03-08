using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bib");
            list.Add("Ana");

            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine(pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(0,1);
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
