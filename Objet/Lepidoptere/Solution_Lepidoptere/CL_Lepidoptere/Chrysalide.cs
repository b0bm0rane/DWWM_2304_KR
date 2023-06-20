using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Lepidoptere
{
    internal class Chrysalide : Stade
    {

        public override void SeDeplacer()
        {

            Console.WriteLine("Je glande !");

        }

        public override Stade SeMetamorphoser()
        {

            return new Papillon();

        }



    }
}
