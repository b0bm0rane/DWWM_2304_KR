namespace Exo_4_6_Pendu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mot;

            string lettreSaisie;

            char lettre;

            char[] tabMot;

            

            int essais;

            bool lettreTrouvee;

            bool gagne;

            Console.WriteLine("Bienvenue dans le programme du pendu");

            do {

                Console.WriteLine("Saisissez un mot de 5 lettres minimum");

                mot = Console.ReadLine();

                Console.WriteLine("Alerte aux gaugaules, alerte aux gaugaules les enfants !!!");

            }
            while (mot == "" || mot.Length < 5);

            Console.Clear();

            tabMot = mot.ToCharArray();
            
            char[] tabMotMystere = new char[tabMot.Length];

            Array.Copy(tabMot, tabMotMystere, tabMot.Length);


            essais = 6;

            for (int i = 1; i < tabMotMystere.Length - 1; i++)
            {

                if (tabMotMystere[i] != ' ') {

                    tabMotMystere[i] = '-';
                
                }
            }

            do
            {

                Console.WriteLine(tabMotMystere);

                do
                {

                    do
                    {

                        Console.WriteLine("Saisissez une lettre");

                        lettreSaisie = Console.ReadLine();

                    }
                    while (!char.TryParse(lettreSaisie, out lettre)); // Tente de convertir lettreSaisie en char, et si possible, le stock dans lettre

                }
                while (lettre == ' ');

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

                    Console.WriteLine("La lettre " + lettre + " est présente dans le mot, il vous reste " + essais + " essais");

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

                    Console.WriteLine("La lettre " + lettre + " n'est pas présente dans le mot, il vous reste " + essais + " essais");

                }

                gagne = true;

                for (int i = 1; i < tabMotMystere.Length-1; i++)
                {
                    if (tabMotMystere[i].CompareTo('-') == 0)
                    {
                        gagne = false;
                    }
                     
                }
               

                   

            }
            while (essais > 0 && gagne == false);

            if (gagne == true)
            {

                Console.WriteLine("Vous avez gagné, le mot était " + mot);

            }
            else
            {

                Console.WriteLine("Vous avez perdu, vous êtes pendu, le mot était " + mot);

            }

        }
    }
}