using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Roue
    {

        private int dimensionPneu;
        private bool tourne;

        public Roue()
        {

            this.dimensionPneu = 50;
            this.tourne = true;

        }

        public bool Stopper()
        {

            if (this.tourne)
            {

                this.tourne = false;
                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Tourner()
        {

            if (!this.tourne)
            {

                this.tourne = true;
                return true;

            }
            else
            {

                return false;

            }

        }

    }
}
