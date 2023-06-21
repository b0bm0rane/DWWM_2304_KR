using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    internal class Roue
    {

        private int dimensionPneuEnCm;
        private double vitesseEnKmh;

        public Roue()
        {

            this.dimensionPneuEnCm = 50;
            this.vitesseEnKmh = 10;

        }

        public bool Stopper()
        {

            if (this.vitesseEnKmh > 0)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Tourner()
        {

            if (this.vitesseEnKmh > 0)
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
