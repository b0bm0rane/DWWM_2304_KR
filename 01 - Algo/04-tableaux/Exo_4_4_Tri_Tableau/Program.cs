namespace Exo_4_4_Tri_Tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = { 128, 64, 8, 512, 16, 32, 256 };
            int temp;
            int indiceMin;

            Console.WriteLine("Bienvenue dans le programme de tri d'un tableau");

            Console.WriteLine(tableau[0] + ", " + tableau[1] + ", " + tableau[2] + ", " + tableau[3] + ", " + tableau[4] + ", " + tableau[5] + ", " + tableau[6]);


            for (int indiceA = 0; indiceA < tableau.Length; indiceA++)
            {

                indiceMin = indiceA;

                for (int indiceB = indiceA + 1; indiceB < tableau.Length; indiceB++)
                {
                    if (tableau[indiceB] < tableau[indiceMin])
                    {

                        indiceMin = indiceB;

                    }

                   
                }

                temp = tableau[indiceMin];
                tableau[indiceMin] = tableau[indiceA];
                tableau[indiceA] = temp;

            }

            Console.WriteLine(tableau[0] + ", " + tableau[1] + ", " + tableau[2] + ", " + tableau[3] + ", " + tableau[4] + ", " + tableau[5] + ", " + tableau[6]);

        }
    }
}