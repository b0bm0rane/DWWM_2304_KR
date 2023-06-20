using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere
{
    public class Lepidoptere
    {

        private Stade stadeCourant;

        public Lepidoptere()
        {
            this.stadeCourant = new Chenille();
        }

        public void SeDeplacer()
        {
            this.stadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            this.stadeCourant = this.stadeCourant.SeMetamorphoser();
        }

    }
}
