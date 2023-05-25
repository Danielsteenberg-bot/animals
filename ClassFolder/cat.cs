using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace animals.ClassFolder
{
    internal class Cat : Animal
    {
        public string FurColor { get; set; }
        public bool Domesticated { get; set; }

        // Constructor
        public Cat(string name, int weight, string diet, string furColor, bool domesticated)
            : base(name, weight, diet)
        {
            FurColor = furColor;
            Domesticated = domesticated;
        }
    }
}

