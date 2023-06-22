using CL_Voiture;

namespace Console_Voiture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roue r = new Roue();
            Roue r2 = new Roue();

            Moteur m = new Moteur();
            bool okm = m.Demarrer();
            bool ok = m.EntrainerRoues(r, r2);

            /*try
            {
                Voiture v = new Voiture("Peugeot",
                    new List<Roue> { new Roue(), new Roue(), new Roue(), new Roue(), new Roue() },
                    new Moteur());

                Voiture v2 = new Voiture("Peugeot",
                    new List<Roue> { r, r2, new Roue(), new Roue() },
                     m);

                Voiture v3 = new Voiture("Peugeot", "22/45 R12 55", false, false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }*/

        }
    
    }
}