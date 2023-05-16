namespace Exo_5_2_1_conversion_km_miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valeurKm = 0;
            double valeurMiles = 0;
            string saisie;
            bool sortir = false;

            const string SORTIE = "q";

            Console.WriteLine("Bienvenue dans le programme de conversion kilomètres <--> miles");

            do
            {

                Console.WriteLine("Saisissez une valeur en km comprise entre 0,01 et 1 000 000 ou q pour quitter le programme");

                saisie = Console.ReadLine();

                if (saisie == SORTIE) // si on a saisi q
                {

                    sortir = true;

                }
                else
                {

                    valeurKm = double.Parse(saisie); // on convertit saisie en double

                    if (valeurKm < 0.01 || valeurKm > 1000000)
                    {

                        Console.WriteLine("Alerte aux gogoles, alerte aux gogoles les enfants !");
                        Console.WriteLine();

                    }

                }

            }
            while (!sortir && (valeurKm < 0.01 || valeurKm > 1000000));

            if (sortir)
            {

                Console.WriteLine("Fin du programme, le gogole est parti !");

            }
            else
            {

                valeurMiles = valeurKm * 1.609;

                Console.WriteLine(valeurKm + " km = " + valeurMiles + " miles");

            }

        }
    }
}