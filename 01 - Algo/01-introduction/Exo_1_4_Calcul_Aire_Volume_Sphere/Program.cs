namespace Exo_1_4_Calcul_Aire_Volume_Sphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aire;
            double rayon;
            double volume;

            Console.WriteLine("Bienvenue dans le programme de calcul de l'aire et du volume d'une sphère");

            Console.WriteLine("Veuillez saisir le rayon de la sphère en cm");

            rayon = double.Parse(Console.ReadLine());

            aire = 4 * Math.PI * Math.Pow(rayon,2);

            volume = 4/3d * Math.PI * Math.Pow(rayon, 3);

            Console.WriteLine("L'aire de la sphère est " + aire + " cm2 et son volume est " + volume + " cm3.");

            Console.ReadLine();
        }
    }
}