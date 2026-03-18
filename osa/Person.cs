using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace tasks.osa
{
    public class Person
    {
        public string Name { get; set; }
        public static void Person1()
        {
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
                Console.WriteLine("Mati olemas");

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));
            nimed.Sort();
            Console.WriteLine(nimed);

            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }




        }
        public static void Tuple()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }
        public static void List()
        {
            List<string> people = new List<string>() { "Kadi", "Mirje" };

            foreach (string p in people)
                Console.WriteLine(p);
            //kustutamine Lisa nimega objekti litsid
            people.Remove("Lisa");
            //näitab, et Lisa nimega objekti listis et olundki, sest see oli erinev objekt, kuigi nime poolest sama
            foreach (string p in people)
                Console.WriteLine(p);
            people.RemoveAt(0);
            people.Insert(0, "Kadi");
            people.Insert(1, "Mirje");
            //sortimerimine
            people.Sort();
            foreach (string p in people)
                Console.WriteLine(p);
            //sortima nimed pikkus järgi
            people.Sort((a, b) => a.Length.CompareTo(b.Length));
            foreach (string p in people)
                Console.WriteLine(p);
            //BinarySearch
            people.BinarySearch("Kadi");

            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);
        }
        public static void Osa4()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            loetelu.AddBefore(loetelu.Find(555), 1);
            loetelu.AddAfter(loetelu.Find(555), 1);
            

        }   
    } 
}

