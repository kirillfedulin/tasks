using System;
using System.Collections.Generic;
using System.Text;
using Person;

namespace tasks.osa
{
    public class StartPage5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sissesta number: ");
            Console.WriteLine("1. Person1();");
            Console.WriteLine("2. TupleExample();");
            Console.WriteLine("3. ListExample();");
            Console.WriteLine("LinkedListExample();");
            Console.WriteLine("DictionaryExample();");
            Console.WriteLine("Kalorite_kalkulaator();");

            string user = Console.ReadLine();

            if (user=="1")
            {
                Person.Person.Person1();
            }
            else if (user=="2")
            {
                Person.Person.TupleExample();
            }
            else if (user=="3")
            {
                Person.Person.ListExample();
            }
            else if (user=="4")
            {
                Person.Person.LinkedListExample();
            }
            else if (user=="5")
            {
                Person.Person.DictionaryExample();
            }
            else if (user=="6")
            {
                Person.Person.Kalorite_kalkulaator();
            }


        }
    }
}
