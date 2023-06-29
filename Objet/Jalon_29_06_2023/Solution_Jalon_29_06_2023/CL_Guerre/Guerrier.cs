using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Guerre
{
    public class Guerrier
    {
        private string nom;
        private int vie;
        private string nomArme1;
        private string nomArme2;
        private int puissanceArme1;
        private int puissanceArme2;
        private int puissanceTotale;

        public Guerrier(string _nom, string _nomArme1, string _nomArme2, int _puissanceArme1, int _puissanceArme2)
        {
            this.nom = _nom;
            this.vie = 10;
            this.nomArme1 = _nomArme1;
            this.nomArme2 = _nomArme2;
            this.puissanceArme1 = _puissanceArme1;
            this.puissanceArme2 = _puissanceArme2;
            this.puissanceTotale = this.puissanceArme1 + this.puissanceArme2;
        }

        public int VieRestante()
        {
            return vie;
        }

        public bool Attaquer (Guerrier guerrierAttaqué)
        {
            if (this.puissanceTotale > guerrierAttaqué.puissanceTotale)
            {
                guerrierAttaqué.vie--;
                return true;
            }
            else
            {
                this.vie--;
                return false;
            }
        }
    }
}
