using animals.ClassFolder;

namespace Animals
{
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

    public class Program
    {
        public static void Main()
        {

            //  Cat lion = new(name: userInput2, 100, "carnivore", "cream", false);
            //  Console.WriteLine($"Animal name: {lion.Name}, Animal Weight: {lion.Weight}kg, Animal Diet: {lion.Diet}, Animal fur color: {lion.FurColor}, Is the animal domesticated: {lion.Domesticated}");

            Bird sparrow = new("Sparrow", 30, "Omnivore", 15, "Brown");
            Console.WriteLine($"Name: {sparrow.Name}, Weight: {sparrow.Weight}g, Diet: {sparrow.Diet}, Wingspan: {sparrow.Wingspan}cm, Beak Color: {sparrow.BeakColor}");

            Cat siamese = new("Siamese", 5, "Carnivore", "Cream", true);
            Console.WriteLine($"Name: {siamese.Name}, Weight: {siamese.Weight}kg, Diet: {siamese.Diet}, Fur Color: {siamese.FurColor}, Domesticated: {siamese.Domesticated}");

            Spider blackWidow = new("Black Widow", 002, "Carnivore", "Ambush", true);
            Console.WriteLine($"Name: {blackWidow.Name}, Weight: {blackWidow.Weight}g, Diet: {blackWidow.Diet}, Hunting Style: {blackWidow.HuntingStyle}, Poisonous: {blackWidow.Poisonous}");


            Spider houseSpider = new("House Spider", 001, "Carnivore", "Ambush", true);
            Console.WriteLine($"Name: {houseSpider.Name}, Weight: {houseSpider.Weight}g, Diet: {houseSpider.Diet}, Hunting Style: {houseSpider.HuntingStyle}, Poisonous: {houseSpider.Poisonous}");

        }

    }
}