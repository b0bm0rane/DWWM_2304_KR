namespace Exo_2_5_Ma_Bicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean beauTemps;
            Boolean etatBicyclette;
            Boolean reparationsImmediate;
            Boolean gotSalon;
            Boolean gotBibliotheque;
            string saisie;

            Console.WriteLine("Bienvenue dans le programme de ma bicyclette");

            Console.WriteLine("Fait-il beau ? oui ou non ?");

            saisie = Console.ReadLine();

            if (saisie == "oui")
            {

                Console.WriteLine("Je vais me promener");

                Console.WriteLine("Ma bicyclette est-elle en bon état ? oui ou non ?");

                saisie = Console.ReadLine();

                if (saisie == "oui")
                {

                    Console.WriteLine("Je vais me promener en vélo");

                }

                else
                {

                    Console.WriteLine("Je vais au garage");

                    Console.WriteLine("Les réparations sont-elles immédiates ? oui ou non ?");

                    saisie = Console.ReadLine();

                    if (saisie == "oui")
                    {

                        Console.WriteLine("Je vais me promener en vélo");

                    }

                    else
                    {

                        Console.WriteLine("Je vais me promener à pied");

                    }

                }

            }

            else if (saisie == "non")
            {

                Console.WriteLine("Je reste au chaud pour lire le premier tome de GOT");

                Console.WriteLine("Le livre est-il dans la bibliothèque du salon ? oui ou non ?");

                saisie = Console.ReadLine();

                if (saisie == "oui")
                {

                    Console.WriteLine("Je m'installe dans mon fauteuil pour lire");

                }

                else
                {

                    Console.WriteLine("Je vais le chercher à la bibliothèque municipale");

                    Console.WriteLine("Le livre est-il à la bibliothèque municipale ? oui ou non ?");

                    saisie = Console.ReadLine();

                    if (saisie == "oui")
                    {

                        Console.WriteLine("Je rentre lire ce livre dans mon fauteuil");

                    }
                    else
                    {

                        Console.WriteLine("Le livre n'est pas là alors je prends un roman policier et rentre le lire au chaud dans mon fauteuil");
                        
                    }

                }

            }

            Console.ReadLine();


            
        }
    }
}