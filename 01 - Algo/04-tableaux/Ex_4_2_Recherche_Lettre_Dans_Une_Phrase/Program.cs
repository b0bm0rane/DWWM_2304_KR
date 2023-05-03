using System.Globalization;

namespace Ex_4_2_Recherche_Lettre_Dans_Une_Phrase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le programme de recherche d'une lettre dans une phrase");

            string lettre;
            string phrase;

            phrase = "J'ai un chat.";

            Console.WriteLine("Saissez une lettre");

            lettre = Console.ReadLine();
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
}