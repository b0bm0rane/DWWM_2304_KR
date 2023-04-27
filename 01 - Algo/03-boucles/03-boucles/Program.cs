namespace Exo_3_1_Controle_Saisie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prenom;

            Console.WriteLine("Bienvenue dans le programme de controle de saisie");

            do
            {

                Console.WriteLine("Veuillez saisir votre prénom (2 caractères minimum)");

                prenom = Console.ReadLine();

            }

            while (prenom.Length < 2);

            Console.WriteLine("Bonjour " + prenom);

            Console.ReadLine();

        }
    }
}