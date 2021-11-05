using System;

namespace abstractions1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                divan dvn1 = new divan();
                Masa calisma_masasi = new Masa();
                dvn1.renk = "qara";
                dvn1.parca = "ag";
                calisma_masasi.renk = "Sarı";
                calisma_masasi.malterial = "boz";
                dvn1.xusisiyyetyazin();
                calisma_masasi.xusisiyyetyazin();
             
                Console.ReadKey();
            }
    }
}
