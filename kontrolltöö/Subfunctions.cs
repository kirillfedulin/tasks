using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp.kontrolltöö
{
    public class Subfunctions
    {
        public static float KytuseKalkulaator()
        {
            Console.WriteLine("Plaun sissesta teepikkus");
            int teepikkus = int.Parse(Console.ReadLine());
            Console.WriteLine("Sissesta kütusekulu 100km kohta (liitrit).");
            int kütusekulu = int.Parse(Console.ReadLine());
            Console.WriteLine("Sissesta Kütuse liitri hind (€).");
            int hind = int.Parse(Console.ReadLine());
            float kogukulu = (teepikkus / 100) * kütusekulu;
            float maksumis = kogukulu * hind;
            Console.Write($"Kokku kulus: {kogukulu}");
            Console.WriteLine($"Reisi: {maksumis}");
            
        }
        public static string HindaIsikukood()
        {
            Console.WriteLine("Sissesta palun sinu isukikood: ");
            int kood = int.Parse(Console.ReadLine());
            if (kood > 11)
            {
                Console.WriteLine("Sissesta ainult 11 sümbolid!");
            }
            if (kood < 0)
            {
                Console.WriteLine("Sissesta 11 sümbolid!");
            }

        }
        public static string TaringuMang()
        {
            Random rnd = new Random();
            List<int> samad = new List<int>();
            int d = 0;
            int k = 0;

            for(int i; )
        }

    }
}
