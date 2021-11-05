using System;
using System.Collections.Generic;
using System.Text;

namespace abstractions1
{
    class Masa:mebel
    {
        
        
            public string  material;
        internal string malterial;

        public override void xusisiyyetyazin()
        {

            Console.WriteLine("Masanın xususiyyetleri");
            Console.WriteLine("Renk: {0}", renk);
            Console.WriteLine("Material: {0}", material);
        }

     
    }
    }

