namespace Exo_2_4_Tri_Nombres___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.WriteLine("Bienvenue dans le programme de tri de 3 nombres par ordre décroissant");

            Console.WriteLine("Veuillez saisir le 1er nombre");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le 2nd nombre");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le 3ème nombre");

            c = int.Parse(Console.ReadLine());

            if (a > b && b > c)
            
            {

                Console.WriteLine(a + " > " + b + " > " + c);

            }

            else if (a > c && c > b) 
            
            {

                Console.WriteLine(a + " > " + c + " > " + b);
            
            }

            else if (b > a && a > c)
            
            {

                Console.WriteLine(b + " > " + a + " > " + c);

            }

            else if (b > c && c > a)
            
            {

                Console.WriteLine(b + " > " + c + " > " + a);

            }

            else if (c > a && a > b)
            
            {

                Console.WriteLine(c + " > " + a + " > " + b);

            }

            else if (c > b && b > a)
            
            {

                Console.WriteLine(c + " > " + b + " > " + a);

            }

            Console.WriteLine();

        }
    }
}