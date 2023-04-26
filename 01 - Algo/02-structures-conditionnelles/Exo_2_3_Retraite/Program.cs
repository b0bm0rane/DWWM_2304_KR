namespace Exo_2_3_Retraite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Bienvenue dans le programme utopique de retraite à 60 ans");

            Console.WriteLine("Veuillez saisir votre âge en années");

            a = int.Parse(Console.ReadLine());

            if (a > 60) 
            
            {

                Console.WriteLine("Vous êtes à la retraite depuis " + (a -60) + " années.");
            
            }

            else if (a > 0 && a < 60)
            
            {

                Console.WriteLine("Il vous reste " + (60 - a) + " années avant la retraite");

            }

            else if (a == 60)
            
            {

                Console.WriteLine("C'est le moment de prendre sa retraite");

            }

            else
            
            {

                Console.WriteLine("La valeur fournie n'est pas un âge valide");

            }

            Console.WriteLine();

        }
    }
}