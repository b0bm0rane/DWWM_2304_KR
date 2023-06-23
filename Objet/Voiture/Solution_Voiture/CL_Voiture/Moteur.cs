using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CL_Voiture
{
    public class Moteur
    {

        private bool enMarche;

        public Moteur()
        {

            enMarche = false;

        }

        public bool Demarrer()
        {

            if (!this.enMarche)
            {

                this.enMarche = true;
                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Eteindre()
        {

            if (this.enMarche)
            {

                this.enMarche = false;
                return true;

            }
            else
            {

                return false;

            }

        }

        public bool ArreterRoues(Roue roue1, Roue roue2)
        {
            bool roue1ok = roue1.Stopper();
            bool roue2ok = roue2.Stopper();

            return (roue1ok && roue2ok);

        }

        public bool EntrainerRoues(Roue roue1, Roue roue2)
        {

            bool roue1ok = roue1.Tourner();
            bool roue2ok = roue2.Tourner();

            return (roue1ok && roue2ok);

        }

    }
}
