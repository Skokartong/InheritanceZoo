using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{

    // Sub class 'Tiger'
    public class Tiger : Animal
    {
        public Tiger()
        {
            Name = "Roger";
            Age = 13;
            Species = "Tiger";
            Colour = "Orange with black stripes";
            Sound = "rawrrr rawrr";
            Food = "a crocodile";
        }

        // ASCII-art tiger
        public void ShowTiger()
        {
            Console.WriteLine("                       __,,,,_\r\n          _ __..-;''`--/'/ /.',-`-.\r\n      (`/' ` |  \\ \\ \\\\ / / / / .-'/`,_\r\n     /'`\\ \\   |  \\ | \\| // // / -.,/_,'-,\r\n    /<7' ;  \\ \\  | ; ||/ /| | \\/    |`-/,/-.,_,/')\r\n   /  _.-, `,-\\,__|  _-| / \\ \\/|_/  |    '-/.;.\\'\r\n   `-`  f/ ;      / __/ \\__ `/ |__/ |\r\n        `-'      |  -| =|\\_  \\  |-' |\r\n              __/   /_..-' `  ),'  //\r\n          fL ((__.-'((___..-'' \\__.'");
        }
    }
}
