using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere
{
    internal class Lepidoptere
    {

        private bool estMouvant;
        private bool estVivant;

        public Lepidoptere()
        {

            estMouvant = true;
            estVivant = true;

        }

        public bool SeDeplacer()
        {

            if (this.estMouvant && this.estVivant)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

    }
}
