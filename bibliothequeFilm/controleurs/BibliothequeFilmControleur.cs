using BibliothequeFilm.Modeles;

namespace BibliothequeFilm.Controleurs

{
    public class BibliothequeFilmControleur
    {
        private static BibliothequeFilmControleur instance;

        private Film monFilm;
        private Acteur unActeur;

        private BibliothequeFilmControleur()
        {

        }
        public static BibliothequeFilmControleur Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BibliothequeFilmControleur();
                }
                return instance;
            }
        }
    public bool CreerFilm(string titre, string langue, int anneeSortie, int dureeEnMinutes, int evaluation, string nomCategorie, string coteCategorie)
        {
            Film monFilm = new Film(titre, langue, anneeSortie, dureeEnMinutes, evaluation, nomCategorie, coteCategorie);

            return monFilm != null;
        }

    public string GetFilmInfos()
        {
            return monFilm.ToString();
        }
    public bool AjouterActeur(string nom, string prenom, int anneeNaissance, int anneeDebutCinema, int nombreFilmParticipe, double salaireParFilm)
        {
            Acteur unActeur = new Acteur(nom, prenom, anneeNaissance, anneeDebutCinema, nombreFilmParticipe, salaireParFilm);

            return monFilm.AjouterActeur(unActeur);
        }

    public string GetActeurInfos()
        {
            return unActeur.ToString();
        }
    }
}