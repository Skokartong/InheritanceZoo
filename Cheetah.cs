using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    // Sub class 'Cheetah' that inherits from sub class 'Tiger'
    class Cheetah : Tiger
    {
        public Cheetah()
        {
            Name = "Henke";
            Age = 5;
            Species = "Cheetah";
            Colour = "Beige with black spots";
            Sound = "roars";
            Food = "a monkey";
        }

        // A unique method for sub class cheetah
        public void FetchCheetah()
        {
            Console.WriteLine($"{Name} runs fast as you fetch the toy, you better catch up!");
            Console.WriteLine($"He {Sound} violently!");
        }
    }
}
