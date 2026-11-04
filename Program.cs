using System;

namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        int fleches = 5;
        int tirsReussis = 0;

        Console.WriteLine("Vous commencez votre chasse");
        Console.WriteLine();

        while (fleches > 0 && tirsReussis < 3)
        {
            Console.WriteLine("Flèches restantes : " + fleches);
            Console.Write("Résultat du tir (touche/rate) : ");
            string resultat = Console.ReadLine();

            if (resultat == "touche")
            {
                tirsReussis++;
                fleches--;
                Console.WriteLine("Bien joué ! Le cerf est touché");
            }
            else if (resultat == "rate")
            {
                fleches--;
                Console.WriteLine("Raté ! Le cerf s'est échappé de justesse");
            }
            else
            {
                // si on a mal taper on fait une erreur et on redemande
                Console.WriteLine("Saisie invalide, tape \"touche\" ou \"rate\"");
                Console.WriteLine();

            }

            if (tirsReussis == 3)
            {
                Console.WriteLine("Le cerf est abattu !");
            }

            Console.WriteLine();
        }

        Console.WriteLine(" BILAN DE LA CHASSE ");
        Console.WriteLine("Tirs réussis : " + tirsReussis);
        Console.WriteLine("Flèches restantes : " + fleches);

        if (tirsReussis == 3)
        {
            Console.WriteLine("Résultat : chasse réussie !");
        }
        else
        {
            Console.WriteLine("Résultat : chasse ratée !");
        }
    }
}