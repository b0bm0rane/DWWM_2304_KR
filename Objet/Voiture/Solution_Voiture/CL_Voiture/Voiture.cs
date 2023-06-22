using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Voiture
    {

        private string marque;
        private Moteur sonMoteur;
        private List<Roue> ses4Roues;

        public Voiture()
        {

            this.marque = "Peugeot";
            this.sonMoteur = new Moteur();
            this.ses4Roues = new List<Roue>();

        }

        public bool Avancer()
        {

            return this.sonMoteur.Demarrer();
            return this.sonMoteur.EntrainerRoues(ses4Roues[0], ses4Roues[1]);

        }

        public bool Demarrer()
        {

            return this.sonMoteur.Demarrer();

        }

        public bool Freiner()
        {

            return this.sonMoteur.ArreterRoues(ses4Roues[0], ses4Roues[1]);

        }
        
    }
}
