using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere
{
    internal class Papillon : Stade
    {

        public override void SeDeplacer()
        {

            Console.WriteLine("ça plane pour moi !");

        }

        public override Stade SeMetamorphoser()
        {

            return new Papillon();

        }

    }
}
