namespace Exo_3_6_Jeu_Fourchette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int fMin;
            int fMax;
            int essais;
            Boolean trouve;

            Console.WriteLine("Bienvenue dans le programme du jeu de la fourchette");

            Random aleatoire = new Random();
            int mystere = aleatoire.Next(0 , 100);

            fMin = 0;
            fMax = 100;
            essais = 0;
            trouve = false;

            while (!trouve)
            {
                Console.WriteLine("Saisissez un nombre entre " + fMin + " et " + fMax);

                a = int.Parse(Console.ReadLine());

                essais++;

                if (a == mystere)
                {

                    trouve = true;

                    Console.WriteLine("Trouvé en " + essais + " essais");

                }

                else if (a < mystere)
                {

                    fMin = a;

                }

                else
                {

                    fMax = a;

                }

            }

        }
    }
}