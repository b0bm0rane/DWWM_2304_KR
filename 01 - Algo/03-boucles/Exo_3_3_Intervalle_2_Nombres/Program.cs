namespace Exo_3_3_Intervalle_2_Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int i;

            Console.WriteLine("Bienvenue dans le programme d'intervalle entre 2 nombres");

            Console.WriteLine("Saisissez le premier nombre");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Saisissez le second nombre");

            b = int.Parse(Console.ReadLine());

            if (a < b) 
            { 

                for (i = a + 1 ; i <= b - 1; i++)
                {

                    Console.WriteLine(i);
                
                }

            }

            else
            {

                for (i = a - 1 ; i >= b + 1 ; i--)
                {

                    Console.WriteLine(i);

                }

            }

        }
    }
}