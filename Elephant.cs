using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    // Sub class 'Elephant'
    class Elephant : Animal
    {
        public Elephant()
        {
            Name = "Nils";
            Age = 50;
            Species = "Elephant";
            Colour = "Grey";
            Sound = "voff voff";
            Food = "a banana";
        }

        // ASCII-art elephant
        public void ShowElephant()
        {
            Console.WriteLine("                        ____\r\n                   .---'-    \\\r\n      .-----------/           \\\r\n     /           (         ^  |   __\r\n&   (             \\        O  /  / .'\r\n'._/(              '-'  (.   (_.' /\r\n     \\                    \\     ./\r\n      |    |       |    |/ '._.'\r\n       )   @).____\\|  @ |\r\n   .  /    /       (    | mrf\r\n  \\|, '_:::\\  . ..  '_:::\\ ..\\).");
        }
    }
}
