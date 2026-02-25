using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naidis_csharp.kontrolltöö
{
    public static void Main(string[] args)
    {
        bool trsukle = true;
        while (trsukle)
        {
            Console.WriteLine("Vali tegevus: ");
            Console.WriteLine("1 - Kütuse kalkulaator");
            Console.WriteLine("2 - Isikukoodi analüüs");
            Console.WriteLine("3 - Täringumäng");
            Console.WriteLine("4 - Palgaarvestus");
            Console.WriteLine("0 - Välju");
            int valik = int.Parse(Console.ReadLine());
            if (valik == 1)
            {
                Subfunctions.KytuseKalkulaator();
            }
            else if (valik == 2)
            {
                Subfunctions.HindaIsikukood();
            }
            else if (valik == 3)
            {
                Subfunctions.TaringuMang();
            }
            else if (valik == 4)
            {

            }
            else if (valik == 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Sissesta palun ainult 1,2,3,4,0");
            }

        }
        
            
        




    }
}
