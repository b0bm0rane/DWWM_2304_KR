using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CL_Point
{
    public class Point
    {

        private decimal x;
        private decimal y;

        public Point()
        {

            this.x = 0;
            this.y = 0;

        }

        public Point(decimal _x, decimal _y)
        {

            this.x = _x;
            this.y = _y;

        }

        public override string ToString()
        {

            return "Point  Abscisse : " + this.x + "|" + "Ordonnée : " + this.y;
        
        }

        public void Deplacer(decimal nouveauX, decimal nouveauY)
        {

            this.x = nouveauX;
            this.y = nouveauY;

        }

        public Point SymOrdonnees()
        {

            Point pointSymOrdonnees = new Point(-this.x, this.y);
            
            return pointSymOrdonnees;

        }
        
        public Point SymAbscisses()
        {

            Point pointSymAbscisses = new Point(this.x, -this.y);

            return pointSymAbscisses;

        }

        public Point SymOrigineS() // simple
        {

            Point pointSymOrigine = new Point(-this.x, -this.y);

            return pointSymOrigine;

        }

        public Point SymOrigineD() // difficile
        {

            Point pointSymOrigine = new Point(this.x, this.y);

            return pointSymOrigine.SymOrdonnees();

            return pointSymOrigine.SymAbscisses();

        }
        
        public void Permuter()
        {

            decimal temp = this.x;
            this.x = this.y;
            this.y = temp;

        }

    }
}
