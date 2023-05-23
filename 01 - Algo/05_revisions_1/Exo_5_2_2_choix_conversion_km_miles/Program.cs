namespace Exo_5_2_2_choix_conversion_km_miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            double valeur;
            string unite;
            bool sorti;

            sorti = false;
            const string SORTIE = "q";

            Console.WriteLine("Bienvenue dans le programme de choix de conversion kilomètres <--> miles");

            /*
            Console.WriteLine("Saisissez la valeur à convertir avec son unité de mesure : km ou mi");
            
            saisie = Console.ReadLine();
            
            unite = saisie.Substring(saisie.Length - 2 , 2); // Piocher une partie de la chaine de caractère : (début saisie longueur saisie - 2 , on prends les 2 derniers indices : saisie --> sais-ie
            



            Console.WriteLine("Saisissez l'unité à convertir, km ou mi");

            unite = Console.ReadLine();

            Console.WriteLine("Saisissez la valeur à convertir");

            saisie = double.Parse(Console.ReadLine());

            if (unite == "km")
            {

                mi = (1.609 * saisie);

                Console.WriteLine(saisie + unite + " = " + mi + " mi");

            }
            else if (unite == "mi")
            {

                km = (saisie / 1.609);

                Console.WriteLine(saisie + unite + " = " + km + " km");

            }
            else
            {

                mi = (1.609 * saisie);

                Console.WriteLine(saisie + "km " + " = " + mi + " mi");

            }
            */
            do
            {

                Console.WriteLine("Saisissez la valeur à convertir avec son unité de mesure : km ou mi");

                saisie = Console.ReadLine();

                if (saisie == "q")
                {

                    sorti = true;

                }
                else if (saisie.Length <= 2)
                {

                    unite = "km";

                }
                else
                {

                    unite = saisie.Substring(saisie.Length - 2, 2); // Piocher une partie de la chaine de caractère : (début saisie longueur saisie - 2 , on prends les 2 derniers indices : saisie --> sais-ie

                    Console.WriteLine("L'unité est : " + unite);

                }

                Console.WriteLine("L'unité est : " + unite);

                if (unite == "km" || unite == "mi" || unite == "")
                {

                    valeur = saisie.Substring(0, saisie.Length - 3);

                }

            } while (sorti == false);
        }
    }
}