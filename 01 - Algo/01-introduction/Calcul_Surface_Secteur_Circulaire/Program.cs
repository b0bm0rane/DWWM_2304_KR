namespace Exo_1_5_Calcul_Surface_Secteur_Circulaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle;
            double rayon;
            double surface;

            Console.WriteLine("Bienvenue dans le programme de calcul de la surface d'un secteur circulaire");

            Console.WriteLine("Veuillez saisir l'angle en degrés");

            angle = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le rayon en cm");

            rayon = double.Parse(Console.ReadLine());

            surface = (Math.PI * Math.Pow(rayon,2) * angle) / 360;

            Console.WriteLine("La surface du secteur circulaire est de " + surface + " cm2.");

            Console.ReadLine();
        }
    }
}