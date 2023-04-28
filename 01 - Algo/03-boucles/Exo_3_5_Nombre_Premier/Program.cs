namespace Exo_3_5_Nombre_Premier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int d;

            Console.WriteLine("Bienvenue dans le programme ");

            Console.WriteLine("Saisissez un nombre entier");

            a = int.Parse(Console.ReadLine());

            for (d = 2; d < a; d++)
            {

                if (a % d == 0)
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
}