namespace Exo_3_7_Barnabé
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int argent;
            int magasins;
            Boolean pauvre;

            Console.WriteLine("Bienvenue dans le programme de Barnabé fait ses courses");

            Console.WriteLine("Saisissez la somme d'argent que possède Barnabé");

            argent = int.Parse(Console.ReadLine());
            magasins = 0;
            pauvre = false;

            if (argent > 1)
            {

                Console.WriteLine("Barnabé possède " + argent + " euros sur lui");

                while (!pauvre)
                {

                    argent = (argent / 2) - 1;
                    magasins++;

                    if (argent <= 0)
                    {

                        pauvre = true;

                        Console.WriteLine("Barnabé a dépensé son argent dans " + magasins + " magasins");

                    }

                }

            }

            else
            {

                Console.WriteLine("La somme d'argent n'est pas supérieur à 1");

            }

        }
    }
}