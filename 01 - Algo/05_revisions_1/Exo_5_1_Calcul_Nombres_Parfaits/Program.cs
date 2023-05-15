namespace Exo_5_1_Calcul_Nombres_Parfaits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombretest;
            int diviseur;
            int totalNbParfaits;
            int sommeDiviseurs;

            Console.WriteLine("Bienvenue dans le programme du calcul des nombres parfaits");
            
//  nombre = 0;
// diviseur = 1;
//   totalNbParfaits = 0;
//for (totalNbParfaits = 0; totalNbParfaits == 4; totalNbParfaits++)
//{
//   Console.WriteLine("Saisissez un nombre entier");
//    nombre = int.Parse(Console.ReadLine());
//  bool trouveParfait = false;

            int compteur = 0;
            int[] nombreParfaits = new int[4];

            int compteurFin = 0;

            nombretest = 1;

            do
            {
                sommeDiviseurs = 0;

                nombretest++;
          
           
                        for (diviseur = 1; diviseur <= nombretest - 1; diviseur++)
                        {

                            if (nombretest % diviseur == 0)
                            {

                                compteur++;

                                Console.WriteLine("Le diviseur numéro " + compteur + "  est : " + diviseur);

                                sommeDiviseurs += diviseur;

                            }

                        }

//  Console.WriteLine(sommeDiviseurs);
                        
                        if (sommeDiviseurs == nombretest)
                        {
                            compteurFin++;
//  trouveParfait = true;
                            nombreParfaits[compteurFin - 1] = sommeDiviseurs;

//foreach (int item in nombreParfaits)
//{
//    Console.Write(item + ", ");
//}

                        }


//if (trouveParfait)
//{
//    Console.WriteLine(nombre + "Le nombre est parfait");
//}
//else
//{   Console.WriteLine(nombre + " n'est pas un nombre parfait");
//}
            } 
            
            while (compteurFin <=3);

            foreach (int nb in nombreParfaits)
            {

                Console.Write(nb + ", ");
            
            }
        }//}
    }
}