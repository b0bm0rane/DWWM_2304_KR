namespace Exo_5_2_1_conversion_km_miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valeurKm;
            double valeurMiles;
            string sortie;

            Console.WriteLine("Bienvenue dans le programme de conversion kilomètres <--> miles");

            sortie = "q";

            do
            {

                Console.WriteLine("Saisissez une valeur en km comprise entre 0,01 et 1 000 000 ou q pour quitter le programme");

                valeurKm = double.Parse(Console.ReadLine());
                
            }

            while (valeurKm < 0.01 || valeurKm > 1000000);

            valeurMiles = valeurKm * 1.609;

            Console.WriteLine(valeurKm + " km = " + valeurMiles + " miles");

            if (valeurKm = sortie)
            {

                Console.WriteLine("Fin du programme");
                
            }

        }
    }
}