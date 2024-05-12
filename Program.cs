using System;
namespace Recherche1
{
    class Program
    {
        // Méthode principale de l’application, qui est le point d'entrée du programme.
        static void Main(string[] args)
        {
            // Déclaration d'un compteur utilisé pour parcourir les tableaux.
            int Cnt = 0;
            // Variable booléenne pour indiquer si le nom recherché a été trouvé.
            bool Trouve = false;
            // Variable pour stocker le nom de l'étudiant entré par l'utilisateur.
            string Test = "";

            // Déclaration et initialisation du tableau des noms d'étudiants.
            string[] Noms = new string[] { "Marc", "Martine", "François", "Charlotte",
                                           "Daniel", "Patricia", "Gregory", "Yves", "Louise",
                                           "Carl" };
            // Déclaration et initialisation du tableau des moyennes associées aux étudiants.
            int[] Moyennes = new int[] { 95, 78, 65, 88, 90, 85, 66, 86, 90, 75 };

            // Demande à l'utilisateur de saisir le nom de l'étudiant recherché.
            Console.Write("Donnez-moi le nom de l'étudiant recherché: ");
            // Lecture de la saisie utilisateur, conversion en minuscules pour faciliter la comparaison.
            Test = Console.ReadLine().ToLower();

            // Boucle pour parcourir le tableau des noms.
            while (Cnt < Noms.Length && !Trouve)
            {
                // Comparaison du nom saisi avec les noms dans le tableau.
                if (Test == Noms[Cnt].ToLower())
                {
                    // Si trouvé, mettre Trouve à true pour arrêter la boucle.
                    Trouve = true;
                    // Affichage de la moyenne de l'étudiant trouvé.
                    Console.WriteLine("La moyenne de {0} est {1}.", Noms[Cnt], Moyennes[Cnt]);
                }
                // Incrémentation du compteur pour passer à l'élément suivant du tableau.
                Cnt++;
            }

            // Si après la recherche, Trouve est toujours false, indiquer que l'étudiant n'est pas trouvé.
            if (!Trouve)
            {
                Console.WriteLine("Étudiant non trouvé.");
            }

            // Attente que l'utilisateur appuie sur une touche avant de fermer la console.
            Console.ReadKey();
        }
    }
}