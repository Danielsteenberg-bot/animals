using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace animals.ClassFolder
{
    public class Bird : Animal
    {

        public int Wingspan { get; set; }
        public string BeakColor { get; set; }

        public Bird(string name, int weight, string diet, int wingspan, string beakColor)
            : base(name, weight, diet)
        {
            Wingspan = wingspan;
            BeakColor = beakColor;
        }
    }
}

