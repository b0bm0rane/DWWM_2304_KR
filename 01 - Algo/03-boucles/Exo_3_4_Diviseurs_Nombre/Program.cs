namespace Exo_3_4_Diviseurs_Nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int d;

            Console.WriteLine("Bienvenue dans le programme de recherche des diviseurs d'un nombre");

            Console.WriteLine("Saisissez un nombre");

            a = int.Parse(Console.ReadLine());

            for (d = 2; d < a ; d++)
            {

                if (a % d == 0)
                {

                    Console.WriteLine(d);

                }

            }

            Console.ReadLine();

        }
    }
}