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
            if (this.denominateur != 0)
            {
                this.numerateur = _numerateur;
                this.denominateur = _denominateur;
            }
            else
            {
                throw new Exception("T'es con ma couille");
            }
            
        }

        public Fraction(int _numerateur)
        {
            this.numerateur = _numerateur;
            this.denominateur = 1;
        }

        public Fraction(Fraction fractionACloner)
        {
            if (this.denominateur != 0)
            {
                this.numerateur = fractionACloner.numerateur;
                this.denominateur = fractionACloner.denominateur;
            }
            else
            {
                throw new Exception("T'es con ma couille");
            }
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
            if (this.denominateur != 0)
            {
                int temp = this.numerateur;
                this.numerateur = this.denominateur;
                this.denominateur = temp;
            }
            else
            {
                throw new Exception("T'es con ma couille");
            }
        }

        public bool SuperieurA(Fraction fractionAComparer)
        {
            return this.Resultat() > fractionAComparer.Resultat();
        }

        public bool EgaleA(Fraction fractionAComparer)
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
            Fraction fractionAReduire = new Fraction(this);

            if (fractionAReduire.numerateur < 0 && fractionAReduire.denominateur < 0)
            {
                fractionAReduire.numerateur = fractionAReduire.numerateur * -1;
                fractionAReduire.denominateur = fractionAReduire.denominateur * -1;
            }

            fractionAReduire.Reduire();
            
            return fractionAReduire;
        }

        public Fraction Plus(Fraction fractionPlus)
        {
            int numerateurPlus = this.numerateur * fractionPlus.denominateur + this.denominateur * fractionPlus.numerateur;
            int denominateurPlus = this.denominateur * fractionPlus.denominateur;

            Fraction resultatPlus = new Fraction(numerateurPlus, denominateurPlus);
            return resultatPlus.FractionReduite();
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
            return resultatMultiplie.FractionReduite();
        }

        public Fraction Divise(Fraction fractionDivise)
        {
            Fraction fractionClone = new Fraction(fractionDivise);

            fractionClone.Oppose();
            return this.Multiplie(fractionClone);
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return a.Plus(b);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            return a.Moins(b);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            return a.Multiplie(b);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            return a.Divise(b);
        }

    }
}
