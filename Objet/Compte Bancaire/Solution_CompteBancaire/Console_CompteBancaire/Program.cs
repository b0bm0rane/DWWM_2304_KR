using CL_CompteBancaire;

namespace Console_CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CompteBancaire CBFlorian = new CompteBancaire(-500, "Florian", 1234, 2000);

            Console.WriteLine(CBFlorian.ToString());

        }
    }
}