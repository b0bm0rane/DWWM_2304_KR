namespace Exo_2_2_Majeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Bienvenue dans le programme de majorité");

            Console.WriteLine("Veuillez saisir votre âge en années");

            a = int.Parse(Console.ReadLine());

            if (a >= 18)

            {

                Console.WriteLine("Vous êtes majeur");

            }

            else if (a > 0 && a < 18)
            
            {

                Console.WriteLine("Vous êtes mineur");

            }

            else 
            
            {

                Console.WriteLine("Vous n'êtes pas né");
            
            }

            Console.WriteLine();

        }
    }
}