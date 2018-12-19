using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class Store : IStore
    {
        // constructors
        public Store(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            Console.Write("Read the Producer's name: ");
            string ProdName = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Car car = new Car(ProdName);
                CarList.Add(car);
                Console.WriteLine();
            }
        }

        // fields
        public string Name { get; private set; }
        private List<Car> CarList = new List<Car>();
        public string Location { get; private set; }
        

        // methods
        public List<Car> AccessCarList()
        {
            return CarList;
        }

        public void ShowCars()
        {
            foreach(Car car in CarList)
            {
                Console.WriteLine($"{car.Brand} - {car.Model} - { car.FabYear} - {car.Price} euro.");
            }
            Console.WriteLine();
        }
    }
}
