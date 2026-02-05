using System;
using System.Linq.Expressions;
using System.Text;

public class StartPage
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        //Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Esimene Andmetuubid, Alanfunktsioonid/meetotid");
        string text = "Tere tulemast C#-i maailma!";
        Console.WriteLine($"Oli loodud muutuja teksti, mis vordub {text}");
        //Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("Mis on nimi? ");
        string name = Console.ReadLine();
        Console.Write("Kui vana sa oled? ");
        try
        {
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sa oled {name} ja sinu vanus on {age} !");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        try
        {
            Console.Write("Arv 1: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Arv 2: ");
            float b = float.Parse(Console.ReadLine());
            float vastus = funkstioonid.Summa(a, b);
            Console.WriteLine($"Summa {a} ja {b} vordub {vastus}");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }


        


    }
}