using System;

namespace Tools
{
    public class Car : Producer
    {
        // constructors
        public Car(string BrandName) : base(BrandName)
        {
            Random random = new Random();
            RandomDeffect = random.Next(0, 2);
            Console.Write("Model: "); this.Model = Console.ReadLine();
            Console.Write("Fabrication Year: "); this.FabYear = Convert.ToInt32(Console.ReadLine());

            if (FabYear <= 2000)
                Price = random.Next(450, 1300);
            else if (FabYear > 2000 && FabYear <= 2010)
                Price = random.Next(1500, 4301);
            else if (FabYear > 2010)
                Price = random.Next(6301, 11721);
        }

        // fields
        public string Model { get; private set; }
        public int FabYear { get; private set; }
        public int RandomDeffect { get; private set; }
        public double Price { get; private set; }

    }
}
