using System.Globalization;

namespace Ex_4_2_Recherche_Lettre_Dans_Une_Phrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lettre;
            string phrase;
            int indice;
            int occurences;

            Console.WriteLine("Bienvenue dans le programme de recherche d'une lettre dans une phrase");

            phrase = "J'ai un chat.";

            Console.WriteLine("Saissez une lettre");

            lettre = char.Parse(Console.ReadLine());

            indice = 0;
            occurences = 0;

            if (phrase == "" || phrase == ".")
            {

                Console.WriteLine("La chaine est vide");

            }

            else
            {

                for (indice = 0 ; indice < phrase.Length ; indice++)
                {

                    if (phrase[indice] == lettre)
                    {

                        occurences++;
                    }

                }

                if (occurences > 0)
                {

                    Console.WriteLine("La lettre " + lettre + " est présente " + occurences + " fois dans la phrase");

                }

                else
                {

                    Console.WriteLine("La lettre " + lettre + " n'est pas présente");

                }

            }

        }

            /*
            if ( phrase == "" || phrase == ".")
            {

                Console.WriteLine("La chaine est vide");

            }

            else

            {

                if (phrase.Contains(lettre))
                {

                    Console.WriteLine("La lettre est présente une ou plusieurs fois");

                }

                else
                {

                    Console.WriteLine("La lettre n'est pas présente");

                }
            
            }*/



    }
}