using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /// <summary>
        /// Calcul de permutation, d'arrangement ou de combinaison des éléments choisis par l'utilisateur
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                // Choix d'opérations possibles 
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) { Environment.Exit(0); }

                if (choix == 1)
                {
                    // le nombre d'éléments à gérer
                    Console.Write("nombre total d'éléments à gérer = ");
                    int cardinal = int.Parse(Console.ReadLine()); 
                    // calcul de r
                    long r = 1;
                    for (int k = 1; k <= cardinal; k++)
                        r *= k;
                    Console.WriteLine(cardinal + "! = " + r);
                }
                else
                {
                    if (choix == 2)
                    {
                        // le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int cardinal = int.Parse(Console.ReadLine()); 
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int sous_ensemble = int.Parse(Console.ReadLine());
                        // calcul de r
                        long r = 1;
                        for (int k = (cardinal - sous_ensemble + 1); k <= cardinal; k++)
                            r *= k;
                        Console.WriteLine("A(" + cardinal + "/" + sous_ensemble + ") = " + r);
                    }
                    else
                    {
                        // le nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        int cardinal = int.Parse(Console.ReadLine());
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        int sous_ensemble = int.Parse(Console.ReadLine());
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (cardinal - sous_ensemble + 1); k <= cardinal; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= sous_ensemble; k++)
                            r2 *= k;
                        // calcul de r3
                        Console.WriteLine("C(" + cardinal + "/" + sous_ensemble + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
