namespace Exo_4_5_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texte;
            int indiceA;

            Console.WriteLine("Bienvenue dans le programme du palindrome");

            Console.WriteLine("Saisissez du texte");

            texte = Console.ReadLine();

            indiceA = 0;

            while (indiceA < (texte.Length - 1 - indiceA))
            {

                indiceA++;

            }

            if (indiceA > (texte.Length - 1 - indiceA))
            {

                Console.WriteLine("Le texte est un palindrome");

            }

            else
            {

                Console.WriteLine("Le texte n'est pas un palindrome");

            }

        }
    }
}