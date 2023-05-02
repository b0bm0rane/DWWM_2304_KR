namespace Exo_3_5_Nombre_Premier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int d;
            Boolean estPremier;

            Console.WriteLine("Bienvenue dans le programme de détection d'un nombre entier");

            Console.WriteLine("Saisissez un nombre entier");

            a = int.Parse(Console.ReadLine());

            estPremier = true;

            for (d = 2; d < a; d++)
            {

                if (a % d == 0) // a divisible par d
                {

                    estPremier = false;

                }

            }

            if (estPremier == false)
            {

                Console.WriteLine(a + " n'est pas un nombre premier");

            }

            else
            {

                Console.WriteLine(a + " est un nombre premier");

            }

        }
    }
}