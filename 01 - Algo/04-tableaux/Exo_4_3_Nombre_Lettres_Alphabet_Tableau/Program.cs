using System.Net;

namespace Exo_4_3_Nombre_Lettres_Alphabet_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string texte;
            string alphabet;
            int indiceT;
            int indiceA;
            int occurences;

            Console.WriteLine("Bienvenue dans le programme de dénombrage des lettres de l'alphabet dans un tableau");

            alphabet = "abcdefghijklmnopqrstuvwxyz";
            indiceT = 0;
            indiceA = 0;
            occurences = 0;

            do
            {

                Console.WriteLine("Saisissez un texte de minimum 120 caractères");

                texte = Console.ReadLine();

            }

            while (texte.Length < 120);

            for (indiceA = 0 ; indiceA < alphabet.Length ; indiceA++)
            {

                occurences = 0;

                for (indiceT = 0 ; indiceT < texte.Length ; indiceT++)
                {

                    if (alphabet[indiceA] == texte[indiceT])

                            occurences++;

                }

                Console.WriteLine("La lettre " + alphabet[indiceA] + " est présente " + occurences + " fois");

            }

        }
    }
}