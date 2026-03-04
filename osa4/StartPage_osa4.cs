using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace tasks.osa4
{
    internal class StartPage_osa4
    {
        public static void Main(string[] args)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt");
            StreamWriter text = new StreamWriter(path, true);
            Console.WriteLine("Sisesta mingi tekst: ");
            string lause = Console.ReadLine();
            text.WriteLine(lause);
            text.Close();
        }
    }
}
