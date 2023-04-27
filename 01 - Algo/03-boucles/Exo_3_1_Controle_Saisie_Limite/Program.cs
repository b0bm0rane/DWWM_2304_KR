using System.Reflection;

namespace Exo_3_2_Controle_Saisie_Limite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            string mdp;
            int essais;
            Boolean estConnecte;

            mdp = "formation";
            essais = 1;
            estConnecte = false;

            Console.WriteLine("Bienvenue dans le programme de saisie limite");

            while (essais <= 3 && !estConnecte)
            {

                Console.WriteLine("Saisissez votre mot de passe");

                saisie = Console.ReadLine();

                if (saisie == mdp)
                {

                    estConnecte = true;

                }

                else
                {

                    essais = essais + 1;

                }

            }

            if (estConnecte)
            {

                Console.WriteLine("Vous êtes connecté");

            }

            else
            {

                Console.WriteLine("Votre compte est bloqué");

            }
        }
    }
}