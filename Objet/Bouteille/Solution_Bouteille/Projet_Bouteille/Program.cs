using CL_Bouteille;
using System.Runtime.CompilerServices;

namespace Projet_Bouteille
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Bouteille bouteilleDeCoke = new Bouteille(false, 0.5f, 0.25f, true, "plastique", "Coke", false);

            bouteilleDeCoke.Ouvrir();
            bouteilleDeCoke.Fermer();
            bouteilleDeCoke.Remplir();
            bouteilleDeCoke.Vider();
            bouteilleDeCoke.Ouvrir();
            bouteilleDeCoke.Remplir(0.1f);
            bouteilleDeCoke.Vider(0.1f);

            Bouteille bouteilleDeVin = new Bouteille();

            bouteilleDeVin.Ouvrir();
            bouteilleDeVin.Fermer();
            bouteilleDeVin.Remplir();
            bouteilleDeVin.Vider();
            bouteilleDeVin.Remplir(0.1f);
            bouteilleDeVin.Vider(0.1f);

            Bouteille bouteilleDijon = new Bouteille(bouteilleDeVin);

            bouteilleDijon.Ouvrir();
            bouteilleDijon.Fermer();
            bouteilleDijon.Remplir();
            bouteilleDijon.Vider();
            bouteilleDijon.Remplir(0.1f);
            bouteilleDijon.Vider(0.1f);

        }
    }
}