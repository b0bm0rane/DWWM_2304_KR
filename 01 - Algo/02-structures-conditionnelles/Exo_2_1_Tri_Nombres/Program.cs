namespace Exo_2_1_Tri_Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Bienvenue dans le programme de tri de 2 nombres par ordre croissant");

            Console.WriteLine("Veuillez saisir le 1er nombre");

            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Veuillez saisir le 2nd nombre");

            b = double.Parse(Console.ReadLine());

            if (a < b) 
            
            {

                Console.WriteLine(a + " < " + b);
            
            }

            else if (b < a) 
            
            {

                Console.WriteLine(b + " < " + a);

            }

            else
            
            {

                Console.WriteLine(a + " = " + b);

            }

            Console.WriteLine();

         }
    }
}