using System;

namespace Naidis_csharp
{
    internal class osa3
    {
        public static void ruudud()
        {
            Random rnd = new Random();

            int n = rnd.Next(1, 11);
            int m = rnd.Next(1, 11);

            int start = Math.Min(n, m);
            int end = Math.Max(n, m);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine($"{i} - {i * i}");
            }
        }

        public static void analuus()
        {
            double sum = 0;
            double korrutis = 1;
            double[] arvud = new double[5];

            for (int i = 0; i < arvud.Length; i++)
            {
                Console.Write($"sisesta {i + 1}. arv: ");
                arvud[i] = double.Parse(Console.ReadLine());

                sum += arvud[i];
                korrutis *= arvud[i];
            }

            double keskmine = sum / arvud.Length;

            Console.WriteLine($"sisestasid: {string.Join(", ", arvud)}");
            Console.WriteLine($"summa: {sum}");
            Console.WriteLine($"korrutis: {korrutis}");
            Console.WriteLine($"keskmine: {keskmine}");
        }

        public static void ulesanne3()
        {
            while (true)
            {
                Console.Write("ostsid elevandi ära? ");
                string vastus = Console.ReadLine().ToLower();

                if (vastus == "jah")
                {
                    Console.WriteLine("tubli, ostsid elevandi");
                    break;
                }

                Console.WriteLine("kõik räägivad nii, aga ostsid elevandi ära");
            }
        }

        public static void mang()
        {
            Random rnd = new Random();
            int arv = rnd.Next(1, 101);
            int katsed = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("arva number 1–100: ");
                int arva = int.Parse(Console.ReadLine());
                katsed++;

                if (arva > arv)
                    Console.WriteLine("liiga suur");
                else if (arva < arv)
                    Console.WriteLine("liiga väike");
                else
                {
                    Console.WriteLine($"õige! arvasid {katsed}. katsel");
                    return;
                }
            }

            Console.WriteLine($"ei arvanud ära. õige number oli {arv}");
        }

        public static void suurarv()
        {
            double[] arvud = new double[4];

            for (int i = 0; i < arvud.Length; i++)
            {
                Console.Write($"sisesta {i + 1}. arv: ");
                arvud[i] = double.Parse(Console.ReadLine());
            }

            double max = arvud[0];

            foreach (double arv in arvud)
            {
                if (arv > max)
                    max = arv;
            }

            Console.WriteLine($"suurim arv on: {max}");
        }
    }
}
