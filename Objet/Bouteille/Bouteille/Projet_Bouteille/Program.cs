using CL_Bouteille;
using System.Runtime.CompilerServices;

namespace Projet_Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bouteille bouteilleDeCoke = new Bouteille(false, 0.5f, 0, true, "plastique", "Coke", false);

            bouteilleDeCoke.Ouvrir();

        }
    }
}