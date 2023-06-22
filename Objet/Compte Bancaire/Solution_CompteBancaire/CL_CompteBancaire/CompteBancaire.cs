using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_CompteBancaire
{
    public class CompteBancaire
    {

        private int decouvertAutorise;
        private string nom;
        private int numero;
        private double solde;

        public CompteBancaire(int _decouvertAutorise, string _nom, int _numero, double _solde)
        {

            this.decouvertAutorise = _decouvertAutorise;
            this.nom = _nom;
            this.numero = _numero;
            this.solde = _solde;

        }



    }
}
