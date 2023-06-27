using CL_Point;

namespace Console_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Point point0 = new Point();

            Point point1 = new Point(1, 5);

            //Console.WriteLine(point0.ToString());

            Console.WriteLine("point1 " + point1.ToString());
            

            /*point0.Deplacer(5, 10);

            Console.WriteLine(point0.ToString());

            point0.Permuter();

            Console.WriteLine(point0.ToString());

            Point psymordo = point0.SymOrdonnees();

            Console.WriteLine(psymordo);

            Console.WriteLine(psymordo.ToString());

            Point psymabs = point0.SymAbscisses();

            Console.WriteLine(psymabs.ToString());*/

            Point psymori = point1.SymOrigineS();

            Console.WriteLine("point1 sym origine " + psymori.ToString());

        }
    }
}