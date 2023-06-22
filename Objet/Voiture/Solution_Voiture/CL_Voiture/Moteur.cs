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

            enMarche = true;

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

            if (!this.enMarche)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool EntrainerRoues(Roue roue1, Roue roue2)
        {

            if (this.enMarche)
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
