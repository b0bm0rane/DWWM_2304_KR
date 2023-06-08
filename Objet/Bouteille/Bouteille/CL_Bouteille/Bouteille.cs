using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Bouteille
{
    public class Bouteille
    {
        private bool alcool;
        private float contenanceEnL;
        private float contenuEnL;
        private bool estGazeux;
        private string matiere;
        private string nomBoisson;
        private bool estOuverte;

        public Bouteille(bool _alcool, float _contenanceEnL, float _contenuEnL, bool _estGazeux, string _matiere, string _nomBoisson, bool _estOuverte)
        {

            this.alcool = _alcool;
            this.contenanceEnL = _contenanceEnL;
            this.contenuEnL = _contenuEnL;
            this.estGazeux = _estGazeux;
            this.matiere = _matiere;
            this.nomBoisson = _nomBoisson;
            this.estOuverte = _estOuverte;

        }

        public bool Ouvrir()
        {

            if (!estOuverte)
            {

                this.estOuverte = true;

                return true;

            }
            else
            {

                return false;

            }

        }
        public bool Fermer()
        {

            if (estOuverte)
            {
                this.estOuverte = false;
                
                return true;

            }
            else
            {

                return false;

            }

        }

    }
}
