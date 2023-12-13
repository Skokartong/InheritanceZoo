using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    // Sub class 'Giraffe'
    class Giraffe : Animal
    {
        public Giraffe()
        {
            Name = "Greta";
            Age = 5;
            Species = "Giraffe";
            Colour = "Orange with brown spots";
            Sound = "moo moo";
            Food = "from a tree";
        }

        // ASCII-art giraffe
        public void ShowGiraffe()
        {
            Console.WriteLine("\r\n                     .c.\r\n                   .d$$e$.\r\n                .e$P\"   ^*%\r\n             .e$P\"\r\n           z$$$\"\r\n        z$$$$$F\r\n     .d$$$$$$$F\r\n  .d$$$$$$$$$$F\r\n.3$$$$$$$$$$$$F\r\n  $$$$$\" \"\"$*$\"\r\n   P $\"    $ $\r\n  d d\"     $ $\r\n  $ *      $ $\r\n   ) '     $ $\r\n    % '    $ $\r\n     % \"   $ $\r\n      - )  * *\r\n");
        }
    }
}
