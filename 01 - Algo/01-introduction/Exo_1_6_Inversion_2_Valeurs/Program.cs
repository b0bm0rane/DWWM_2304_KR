namespace Exo_1_6_Inversion_2_Valeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double temp;

            Console.WriteLine("Bienvenue dans le programme d'inversion de 2 valeurs");

            Console.WriteLine("Veuillez saisir le nombre a");

            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le nombre b");

            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Le nombre a = " + a + ". Le nombre b = " + b, ".");

            Console.ReadLine();

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Le nombre a = " + a + ". Le nombre b = " + b, ".");
        }
    }
}