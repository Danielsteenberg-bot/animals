using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace animals.ClassFolder
{
    internal class Spider : Animal
    {
            public string HuntingStyle { get; set; }
            public bool Poisonous { get; set; }

            // Constructor
            public Spider(string name, int weight, string diet, string huntingStyle, bool poisonous)
                : base(name, weight, diet)
            {
                HuntingStyle = huntingStyle;
                Poisonous = poisonous;
            }


        }

    }

