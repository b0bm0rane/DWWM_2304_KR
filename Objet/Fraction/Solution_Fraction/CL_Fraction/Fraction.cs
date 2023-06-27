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
            
        }

    }
}
