using CL_CompteBancaire;

namespace Console_CompteBancaire
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CompteBancaire classique = new CompteBancaire();

            CompteBancaire CBFlorian = new CompteBancaire(-500, "Florian", 1234, 2000);

            CompteBancaire CBToto = new CompteBancaire(-500, "toto", 12345, 1000);

            CompteBancaire CBTiti = new CompteBancaire(-1000, "titi", 45657, 2000);

            Console.WriteLine(classique.ToString());
            
            Console.WriteLine(CBFlorian.ToString());

            CBFlorian.Crediter(100000000);

            CBFlorian.Debiter(3000);

            Console.WriteLine(CBFlorian.ToString());

            Console.WriteLine(CBToto.ToString());

            Console.WriteLine(CBTiti.ToString());

            bool ok2 = CBToto.Transferer(15500, CBTiti);

            Console.WriteLine(CBToto.ToString());

            Console.WriteLine(CBTiti.ToString());

            bool ok = CBToto.Superieur(CBTiti);

        }
    }
}