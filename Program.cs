using System;

namespace Animals { 
    public class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Diet { get; set; }

        // Constructor
        public Animal(string name, int weight, string diet)
        {
            Name = name;
            Weight = weight;
            Diet = diet;
        }
    }

    public class Bird : Animal
    {
        public int Wingspan { get; set; }
        public string BeakColor { get; set; }

        // Constructor
        public Bird(string name, int weight, string diet, int wingspan, string beakColor)
            : base(name, weight, diet)
        {
            Wingspan = wingspan;
            BeakColor = beakColor;
        }
    }

    public class Cat : Animal
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

    public class Spider : Animal
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



    public class Program
    {
        public static void Main()
        {
           // Console.WriteLine("Enter a Animal Kingdom");
           // string userInput1 = Console.ReadLine();
            Console.WriteLine("Enter a name");
            string userInput2 = Console.ReadLine();
            

            Cat lion = new Cat(userInput2, 100, "carnivore", "cream", false);
            Console.WriteLine($"Animal name: {lion.Name}, Animal Weight: {lion.Weight}kg, Animal Diet: {lion.Diet}, Animal fur color: {lion.FurColor}, Is the animal domesticated: {lion.Domesticated}");

            Bird sparrow = new Bird("Sparrow", 30, "Omnivore", 15, "Brown");
            Console.WriteLine($"Name: {sparrow.Name}, Weight: {sparrow.Weight}g, Diet: {sparrow.Diet}, Wingspan: {sparrow.Wingspan}cm, Beak Color: {sparrow.BeakColor}");

            Cat siamese = new Cat("Siamese", 5, "Carnivore", "Cream", true);
            Console.WriteLine($"Name: {siamese.Name}, Weight: {siamese.Weight}kg, Diet: {siamese.Diet}, Fur Color: {siamese.FurColor}, Domesticated: {siamese.Domesticated}");

            Spider blackWidow = new Spider("Black Widow", 002, "Carnivore", "Ambush", true);
            Console.WriteLine($"Name: {blackWidow.Name}, Weight: {blackWidow.Weight}g, Diet: {blackWidow.Diet}, Hunting Style: {blackWidow.HuntingStyle}, Poisonous: {blackWidow.Poisonous}");
        }

    }
}