using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    internal class Moteur
    {

        private bool estEnMarche;

        public Moteur()
        {

            estEnMarche = true;

        }

        public bool Demarrer()
        {

            if (!this.estEnMarche)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Eteindre()
        {

            if (this.estEnMarche)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool ArreterRoues()
        {



        }

        public bool EntrainerRoues()
        {



        }

    }
}
