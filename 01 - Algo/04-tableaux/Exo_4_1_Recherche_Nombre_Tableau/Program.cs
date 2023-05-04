namespace Exo_4_1_Recherche_Nombre_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 8, 16, 32, 64, 128, 256, 512 };
            int indice;
            int nombreATrouver; // nombre à trouver
            Boolean aTrouve;

            Console.WriteLine("Bienvenue dans le programme de recherche d'un nombre dans un tableau");

            Console.WriteLine("Saississez un nombre");

            nombreATrouver = int.Parse(Console.ReadLine());

            indice = 0;
            aTrouve = false;

            while (!aTrouve && ( indice < tableau.Length ))
            {

                if (tableau[indice] == nombreATrouver)
                {

                    aTrouve = true;

                }

                else
                {

                    indice++;

                }

            }

            if (aTrouve)
            {

                Console.WriteLine("L'indice est " + indice);

            }

            else
            {

                Console.WriteLine("Non trouvé");

            }

            /*
            
            int a;
            int[] tab = { 8, 16, 32, 64, 128, 256, 512 };

            Console.WriteLine("Bienvenue dans le programme de recherche d'un nombre dans un tableau");

            Console.WriteLine("Saississez un nombre");

            a = int.Parse(Console.ReadLine());

            if (tab.Contains(a))
            {

                Console.WriteLine(a + " est dans le tableau avec l'indice " + Array.IndexOf(tab, a));

            }

            else
            {

                Console.WriteLine("Nombre non trouvé");

            }
            
            */

        }
    }
}