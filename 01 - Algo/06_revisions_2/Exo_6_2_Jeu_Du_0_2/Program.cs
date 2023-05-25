namespace Exo_6_2_Jeu_Du_0_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbOrdi;
            int nbJoueur;
            int scoreOrdi = 0;
            int scoreJoueur = 0;

            Random aleatoire = new Random();

            Console.WriteLine("Bienvenue dans le programme du jeu 0-2");

            do
            {

                nbOrdi = aleatoire.Next(0, 3);

                Console.WriteLine("Entrer un nombre entre 0 et 2");

                nbJoueur = int.Parse(Console.ReadLine());

                if (nbJoueur < 0)
                {

                    Console.WriteLine("Vous avez abandonné");

                }

                else if (nbJoueur > 2)
                {

                    Console.WriteLine("Votre nombre est supérieur à 2");

                }
                else
                {

                    if (nbOrdi == nbJoueur)
                    {

                        Console.WriteLine("Aucun point n'est marqué");

                    }

                    else if (nbOrdi > nbJoueur)
                    {

                        if (nbOrdi == nbJoueur + 1)
                        {

                            scoreJoueur += 1;

                            Console.WriteLine("Vous avez marqué un point");

                        }
                        else
                        {

                            scoreOrdi += 1;

                            Console.WriteLine("L'ordinateur a marqué un point");

                        }

                    }
                    else
                    {

                        if (nbOrdi == nbJoueur - 1)
                        {

                            scoreOrdi += 1;

                            Console.WriteLine("L'ordinateur a marqué un point");

                        }
                        else
                        {

                            scoreJoueur += 1;

                            Console.WriteLine("Vous avez marqué un point");

                        }

                    }


                }

                Console.WriteLine("Le nombre de l'ordinateur est " + nbOrdi);

            }
            while (!(scoreOrdi >= 10 || scoreJoueur >=10 || nbJoueur < 0));

            if (scoreOrdi == 10)
            {

                Console.WriteLine("L'ordinateur a gagné");

            }
            else if (scoreJoueur == 10)
            {

                Console.WriteLine("Vous avez gagné");

            }


            Console.WriteLine("Le score est de " + scoreOrdi + " pour l'ordinateur et " + scoreJoueur + " pour vous");

        }
    }
}