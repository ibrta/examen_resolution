using System;
namespace Recherche1
{
    class Program
    {
        // Méthode principale de l’application.
        static void Main(string[] args)
        {
            // Déclaration des variables nécessaires pour l’application.
            int Cnt = 0;
            bool Trouve = false;
            string Test = "";
            // Déclaration et initialisation des tableaux.
            string[] Noms = new string[] { "Marc", "Martine", "François", "Charlotte","Daniel", "Patricia", "Gregory", "Yves", "Louise","Carl" };
            int[] Moyennes = new int[] { 95, 78, 65, 88, 90, 85, 66, 86, 90, 75 };
            // Récupération de la saisi du nom de l’étudiant que l’utilisateur désire trouvé.
            Console.Write(" Donnez-moi le nom de l’étudiant recherché : ");
            Test = Console.ReadLine().ToLower();
            Console.ReadKey();
        }
    }
}