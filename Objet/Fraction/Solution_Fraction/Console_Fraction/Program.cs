using CL_Fraction;

namespace Console_Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(-120, 0);

            Fraction fraction2 = new Fraction();

            Fraction fraction3 = new Fraction(9);

            Fraction fraction4 = new Fraction(2, 4);

            Fraction fraction5 = new Fraction(1, 2);

            // Console.WriteLine(fraction1.Resultat());

            //Fraction oppose = fraction1.Oppose();

            //Console.WriteLine(oppose.ToString());

            Console.WriteLine(fraction1.ToString());

            Console.WriteLine(fraction2.ToString());

            // Console.WriteLine(fraction1.Resultat());

            // fraction1.Inverse();

            // Console.WriteLine(fraction1.ToString());

            // Console.WriteLine(fraction1.Resultat());

            // Console.WriteLine(fraction4.ToString());

            // Console.WriteLine(fraction5.ToString());

            // Console.WriteLine(fraction1.FractionReduite());

            // Console.WriteLine(fraction1.ToString());

            //Console.WriteLine(fraction4.Divise(fraction5));

            // Console.WriteLine(fraction4.ToString());
            //Fraction divise = fraction1.Divise(fraction2);
            //Console.WriteLine(divise.ToString());

            Fraction surcharge = fraction1 + fraction2;
            Console.WriteLine(surcharge.ToString());


        }
    }
}