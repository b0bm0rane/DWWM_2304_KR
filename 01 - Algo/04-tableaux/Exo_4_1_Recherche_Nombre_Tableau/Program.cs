namespace Exo_4_1_Recherche_Nombre_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int[] tab = { 8, 16, 32, 64, 128, 256, 512 };

            Console.WriteLine("Bienvenue dans le programme de recherche d'un nombre dans un tableau");

            Console.WriteLine("Saississez un nombre");

            a = int.Parse(Console.ReadLine());

            if (tab.Contains(a))
            {

                Console.WriteLine(a + " est dans le tableau");

            }

            else
            {

                Console.WriteLine("Nombre non trouvé");

            }
        }
    }
}