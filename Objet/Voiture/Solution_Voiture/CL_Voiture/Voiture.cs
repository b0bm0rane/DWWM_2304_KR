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
            this.ses4Roues = new List<Roue>
            {
                new Roue(),
                new Roue(),
                new Roue(),
                new Roue()
            };

        }

        public bool Avancer()
        {

            return this.sonMoteur.EntrainerRoues(this.ses4Roues[0], this.ses4Roues[1]);

        }

        public bool Demarrer()
        {

            return this.sonMoteur.Demarrer();

        }

        public bool Eteindre()
        {

            return this.sonMoteur.Eteindre();

        }

        public bool Freiner()
        {

            return this.sonMoteur.ArreterRoues(this.ses4Roues[0], this.ses4Roues[1]);

        }
        
    }
}
