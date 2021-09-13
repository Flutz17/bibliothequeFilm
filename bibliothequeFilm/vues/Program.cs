using System;
using BibliothequeFilm.Controleurs;

namespace BibliothequeFilm.Vues
{
    class Program
    {
        public const int evaluation = 9;
        public const string coteCategorie = "Tous";
        static void Main(string[] args)
        {
            BibliothequeFilmControleur monControleur = BibliothequeFilmControleur.Instance;

            // Description du FILM
            Console.WriteLine("Veuillez entrer le nom du Film:");
            String titre = Console.ReadLine();
            Console.WriteLine("Dans quelle langue est-il?");
            String langue = Console.ReadLine();
            Console.WriteLine("En quelle année est-il sorti?");
            int anneeSortie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quel est la durée?");
            int dureeEnMinutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De quel type est ce film?");
            String nomCategorie = Console.ReadLine();

            // Création de l'objet film

            monControleur.CreerFilm(titre, langue, anneeSortie, dureeEnMinutes, evaluation, nomCategorie, coteCategorie);

            Console.WriteLine(monControleur.GetFilmInfos());

            // Description des ACTEURS
            Console.WriteLine("Quel est le nom de l'acteur principal:");
            String nom = Console.ReadLine();
            Console.WriteLine("...son prénom?:");
            String prenom = Console.ReadLine();
            Console.WriteLine("Il est né en...?:");
            int anneeNaissance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Il a débuté ce métier en...?:");
            int anneeDebutCinema = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre de films ou il a joué?:");
            int nombreFilmParticipe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Son salaire annuel?:");
            double salaireParFilm = Convert.ToInt32(Console.ReadLine());

            // Création de l'acteur principal
            monControleur.AjouterActeur(nom, prenom, anneeNaissance, anneeDebutCinema, nombreFilmParticipe, salaireParFilm);
            // Création de l'acteur secondaire ("Falardeau", "Pierre", 1979, 1992, 23, 50000);
            monControleur.AjouterActeur("Falardeau", "Pierre", 1979, 1992, 23, 50000);
            // Ajout de l'acteur au film 
            monControleur.AjouterActeur("Mercier", "Lucie", 1968, 1992, 38, 70000);

            Console.WriteLine("");
            Console.WriteLine("Liste des acteurs...");
            Console.WriteLine("");

            // Afficher les acteurs
           

            Console.WriteLine("");
            Console.WriteLine("Informations sur le film...");
            Console.WriteLine("");

            Console.WriteLine("Le film a " + monFilm.GetNombreActeur() + " acteur(s).");
            Console.WriteLine("Le film a coûté " + monFilm.CalculerBudget() + " $ en budget d'acteur(s).");
            Console.WriteLine("La moyenne d'âge des acteurs du film est de " + monFilm.CalculerAgeMoyenActeur() + " an(s).");

            Console.ReadKey();
        }
    }
}
