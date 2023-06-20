using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere
{
    internal class Chenille : Stade
    {
        
        public override void SeDeplacer()
        {

            Console.WriteLine("Je rampe !");

        }

        public override Stade SeMetamorphoser()
        {

            return new Chrysalide();

        }

    }
}
