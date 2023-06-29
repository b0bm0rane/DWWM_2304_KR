using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Fraction
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;

        public Fraction()
        {
            numerateur = 0;
            denominateur = 1;
        }

        public Fraction(int _numerateur, int _denominateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = _denominateur;
        }

        public Fraction(int _numerateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = 1;
        }

        public Fraction(Fraction fractionACloner)
        {
            this.numerateur = fractionACloner.numerateur;
            this.denominateur = fractionACloner.denominateur;
        }

        public override string ToString()
        {
            return this.numerateur + "/" + this.denominateur;
        }

        public double Resultat()
        {
            return (double) this.numerateur / this.denominateur;
        }

        public void Oppose()
        {
            this.numerateur = -this.numerateur;
        }

        public void Inverse()
        {
            int temp = this.numerateur;
            this.numerateur = this.denominateur;
            this.denominateur = temp;
        }

        public bool SuperieurA(Fraction fractionAComparer)
        {
            return this.Resultat() > fractionAComparer.Resultat();
        }

        public bool EgalA(Fraction fractionAComparer)
        {
            return this.Resultat() == fractionAComparer.Resultat();
        }

        private int GetPgdc()
        {
            int a = this.numerateur;
            int b = this.denominateur;
            int pgdc = 1;

            if (a != 0 && b != 0)
            {
                    if (a < 0) a = -a;
                    if (b < 0) b = -b;    
                    while(a != b)
                    {
                        if (a < b)
                        {
                            b = b - a;
                        }
                        else
                        {
                            a = a - b;
                        }
                    }
                    pgdc = a;
            }
            return pgdc;
        }

        private void Reduire()
        {
            int PGDC = this.GetPgdc();
            this.numerateur /= PGDC;
            this.denominateur /= PGDC;
        }

        public Fraction FractionReduite()
        {
            if (this.numerateur < 0 && this.denominateur < 0)
            {
                this.numerateur = this.numerateur * -1;
                this.denominateur = this.denominateur * -1;
            }

            this.GetPgdc();
            this.Reduire();
            
            return this;
        }

        public Fraction Plus(Fraction fractionPlus)
        {
            int numerateurPlus = this.numerateur * fractionPlus.denominateur + this.denominateur * fractionPlus.numerateur;
            int denominateurPlus = this.denominateur * fractionPlus.denominateur;

            Fraction resultatPlus = new Fraction(numerateurPlus, denominateurPlus);
            resultatPlus.FractionReduite();
            return resultatPlus;
        }

        public Fraction Moins(Fraction fractionMoins)
        {
            Fraction fractionClone = new Fraction(fractionMoins);

            fractionClone.Oppose();
            return this.Plus(fractionClone);
        }

        public Fraction Multiplie(Fraction fractionMultiplie)
        {
            int numerateurMultiplie = this.numerateur * fractionMultiplie.numerateur;
            int denominateurMultiplie = this.denominateur * fractionMultiplie.denominateur;

            Fraction resultatMultiplie = new Fraction(numerateurMultiplie, denominateurMultiplie);
            resultatMultiplie.FractionReduite();
            return resultatMultiplie;
        }

        public Fraction Divise(Fraction fractionDivise)
        {
            fractionDivise = new Fraction(fractionDivise);

            fractionDivise.Oppose();
            return this.Multiplie(fractionDivise);
        }

    }
}
