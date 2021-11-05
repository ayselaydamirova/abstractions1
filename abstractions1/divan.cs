using System;
using System.Collections.Generic;
using System.Text;

namespace abstractions1
{
    class divan:mebel 
    {
        public string parca;
        private string material;

        public override void xusisiyyetyazin()
        {
            Console.WriteLine("divan xususiyetleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("material: {0}", material);
        }
    }
}

