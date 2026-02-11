using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{

    public class StartPage_2
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Massivid ja listid");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Tere, {i + 1}! ");
            }
            Console.WriteLine("While:");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Tere, {j + 1}");
                j++;
            }
            do
            {
                Console.WriteLine($"Tere, {j + 1}!");
                j--;
            }
            while (j != 0);

            arvud = Funktsioonid_2.Täida_massiiv(arvud);

            arvud = Funktsioonid_2.Foreach_abil(arvud);

            //Küsi mis positsioonil muuda element ja mis väärtuseks, muda element ja kuva massiiv
            Funktsioonid_2.Muuda_Element(int[] arvud);



        }
    }
}

