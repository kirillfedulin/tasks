using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Person
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

            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
        }

        public static void TupleExample()
        {
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");
        }

        public static void ListExample()
        {
            List<string> people = new List<string>() { "Kadi", "Mirje" };

            foreach (string p in people)
                Console.WriteLine(p);

            people.Remove("Lisa");

            foreach (string p in people)
                Console.WriteLine(p);

            people.RemoveAt(0);
            people.Insert(0, "Kadi");
            people.Insert(1, "Mirje");

            people.Sort();

            foreach (string p in people)
                Console.WriteLine(p);

            people.Sort((a, b) => a.Length.CompareTo(b.Length));

            foreach (string p in people)
                Console.WriteLine(p);

            people.BinarySearch("Kadi");

            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(0);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);
        }

        public static void LinkedListExample()
        {
            LinkedList<int> loetelu = new LinkedList<int>();
            loetelu.AddLast(5);
            loetelu.AddLast(3);
            loetelu.AddFirst(1);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.RemoveFirst();
            loetelu.RemoveLast();
            loetelu.AddLast(555);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            loetelu.Remove(555);

            foreach (int arv in loetelu)
                Console.WriteLine(arv);

            var node = loetelu.Find(555);
            if (node != null)
            {
                loetelu.AddBefore(node, 1);
                loetelu.AddAfter(node, 1);
            }
        }

        public static void DictionaryExample()
        {
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
                Console.WriteLine($"{paar.Key} - {paar.Value}");

            string pealinn = riigid[2];
            Console.WriteLine(pealinn);

            riigid[2] = "Eestimaa";
            riigid.Remove(3);

            bool eesti = riigid.ContainsKey(77);
            Console.WriteLine(eesti);
        }

        public static void Kalorite_kalkulaator()
        {
            List<Toode> tooted = new List<Toode>()
            {
                new Toode() { Nimi = "Õun", Kalorid = 52 },
                new Toode() { Nimi = "Banaan", Kalorid = 89 },
                new Toode() { Nimi = "Kanafilee", Kalorid = 165 }
            };

            string path = "test.txt";

            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("Faili ei leitud");
            }

            foreach (Toode t in tooted)
            {
                Console.WriteLine(t);
            }
        }
    }

    public class Toode
    {
        public string Nimi { get; set; }
        public int Kalorid { get; set; }

        public override string ToString()
        {
            return $"{Nimi} - {Kalorid} kcal";
        }


    }
}
