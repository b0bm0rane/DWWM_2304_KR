internal class Program
{
    private static void Main(string[] args)
    {
        int nombre1;
        int nombre2;
        double moyenne;
        string saisie;

        Console.WriteLine("Bienvenue dans le programme de calcul de la moyenne de 2 nombres");

        Console.WriteLine("Veuillez saisir le premier nombre");

        saisie = Console.ReadLine();

        nombre1 = Convert.ToInt32(saisie); // nombre1 = int.Parse(saisie)

        Console.WriteLine("Veuillez saisir le second nombre");

        nombre2 = int.Parse(Console.ReadLine());

        moyenne = (nombre1 + nombre2) / 2d; //2d ou 2.0 signifie double

        Console.WriteLine("La moyenne de " + nombre1 + " et " + nombre2 + " est " + moyenne);

        Console.ReadLine();
    }
}