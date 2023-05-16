namespace Exo_5_2_2_choix_conversion_km_miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valeurKm = 0;
            double valeurMiles = 0;
            string saisie;
            string unite;
            bool sortir = false;

            const string SORTIE = "q";

            Console.WriteLine("Bienvenue dans le programme de choix de conversion kilomètres <--> miles");

            Console.WriteLine("Saisissez la valeur à convertir avec son unité de mesure : km ou mi");

            saisie = Console.ReadLine();

            unite = saisie.Substring(saisie.Length - 2 , 2); // Piocher une partie de la chaine de caractère : (longueur de la chaine - 2 , les 2 derniers



        }
    }
}