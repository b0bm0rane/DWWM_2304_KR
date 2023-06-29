using CL_Guerre;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Console_Jalon_29_06_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerrier guerrier1 = new Guerrier("guerrier1", "dague", "épée", 2, 4);
            Guerrier guerrier2 = new Guerrier("guerrier2", "sabre", "masse", 5, 9);

            guerrier1.Attaquer(guerrier2);

            Console.WriteLine(guerrier1.VieRestante());
            Console.WriteLine(guerrier2.VieRestante());
        }
    }
}