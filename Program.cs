using System;

namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        int fleches = 5;
        int tirsReussis = 0;

        Console.WriteLine("Inspection des 4 wagons du train");
        Console.WriteLine("Vous commencez votre chasse");
        Console.WriteLine();

        while (fleches > 0 && tirsReussis < 3)
        {
            Console.WriteLine("Flèches restantes : " + fleches);
            Console.Write("Résultat du tir (touche/rate) : ");
            string resultat = Console.ReadLine();

            
    }
}