namespace Exo_1_2_Hello_You
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String prenom;

            Console.WriteLine("Veuillez saisir votre prénom");

            prenom = Console.ReadLine();

            Console.WriteLine("Bonjour " + prenom + ".");

            Console.ReadLine();
        }
    }
}