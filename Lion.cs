using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    // Sub class 'Lion' that inherits from sub class 'Tiger'
    class Lion : Tiger
    {
        public Lion()
        {
            Name = "Lotta";
            Age = 8;
            Species = "Lion";
            Colour = "Orange";
            Sound = "RAWRRR";
            Food = "a deer";
        }

        // A unique method for sub class lion
        public void CuddleLion()
        {
            Console.WriteLine($"As you cuddle with {Name}, she says {Sound}!");
        }
    }
}
