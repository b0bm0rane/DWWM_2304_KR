using CL_Fraction;

namespace Console_Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(12, 7);

            Fraction fraction2 = new Fraction();

            Fraction fraction3 = new Fraction(9);

            // Console.WriteLine(fraction1.Resultat());

            //Fraction oppose = fraction1.Oppose();

            //Console.WriteLine(oppose.ToString());

            Console.WriteLine(fraction1.ToString());

            Console.WriteLine(fraction1.Resultat());

            fraction1.Inverse();

            Console.WriteLine(fraction1.ToString());

            Console.WriteLine(fraction1.Resultat());
        }
    }
}