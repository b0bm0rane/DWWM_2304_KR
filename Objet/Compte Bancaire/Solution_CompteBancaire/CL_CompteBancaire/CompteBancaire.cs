using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CompteBancaire
{
    public class CompteBancaire
    {

        private decimal decouvertAutorise;
        private string nom;
        private int numero;
        private decimal solde;

        public CompteBancaire()
        {

            this.decouvertAutorise = -500;
            this.nom = "Classique";
            this.numero = 0000;
            this.solde = 0;

        }
        public CompteBancaire(decimal _decouvertAutorise, string _nom, int _numero, decimal _solde)
        {

            this.decouvertAutorise = _decouvertAutorise;
            this.nom = _nom;
            this.numero = _numero;
            this.solde = _solde;

        }

        public override string ToString()
        {

            return  "découvert autorisé en euros :" + this.decouvertAutorise + "|" + 
                    "nom du client :" + this.nom + "|" + 
                    "numero du compte bancaire :" + this.numero + "|" + 
                    "solde en euros :" + this.solde;

        }

        public void Crediter(decimal sommeACrediter)
        {

            this.solde += sommeACrediter;

        }

        public bool Debiter(decimal sommeADebiter)
        {

            if ((this.solde - sommeADebiter) >= this.decouvertAutorise)
            {

                this.solde -= sommeADebiter;

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Transferer(decimal sommeATransferer, CompteBancaire compteBancaireDestinataire)
        {
           
            if (this.Debiter(sommeATransferer))
            {

                compteBancaireDestinataire.Crediter(sommeATransferer);

                return true;

            }
            else
            {

                return false;

            }

        }

        public bool Superieur(CompteBancaire compteBancaireAComparer)
        {

            if (this.solde > compteBancaireAComparer.solde)
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
