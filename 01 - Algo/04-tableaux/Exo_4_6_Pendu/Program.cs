namespace Exo_4_6_Pendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mot;

            char lettre;

            char[] tabMot;

            

            int essais;

            bool lettreTrouvee;

            bool gagne;

            Console.WriteLine("Bienvenue dans le programme du pendu");

            do {

                Console.WriteLine("Saisissez un mot de 5 lettres minimum");

                mot = Console.ReadLine();
            }
            while (mot == "");

            Console.Clear();

            tabMot = mot.ToCharArray();
            
            char[] tabMotMystere = new char[tabMot.Length];

            Array.Copy(tabMot, tabMotMystere, tabMot.Length);

            gagne = false;

            essais = 6;

            for (int i = 1; i < tabMotMystere.Length - 1; i++)
            {

                tabMotMystere[i] = '-';

            }

            do
            {

                Console.WriteLine(tabMotMystere);
                
                Console.WriteLine("Saisissez une lettre");

                lettre = char.Parse(Console.ReadLine());

                lettreTrouvee = false;

                for (int i = 1; i < tabMot.Length - 1; i++) // Est-ce que la lettre est présente au moins une fois ?
                {

                    if (tabMot[i] == lettre)
                    {

                        lettreTrouvee = true;

                    }

                }

                if (lettreTrouvee == true)
                {

                    Console.WriteLine("La lettre " + lettre + " est dans le mot");

                    for (int i = 1; i < tabMot.Length - 1; i++)
                    {

                        if (tabMot[i] == lettre)
                        {

                            tabMotMystere[i] = tabMot[i];

                        }

                    }



                }
                else
                {

                    essais = essais - 1;

                }

                if (tabMot == tabMotMystere)
                {

                    gagne = true;

                }
                else
                {

                    gagne = false;

                }

            }
            while (essais > 0 || gagne == false);

            if (gagne == true)
            {

                Console.WriteLine("Vous avez gagné");

            }
            else
            {

                Console.WriteLine("Vous avez perdu");

            }

        }
    }
}