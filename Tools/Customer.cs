using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class Customer : ICustomer
    {
        // constructors
        public Customer(string name)
        {
            this.Name = name;
        }

        // fields
        public string Name { get; private set; }
        public Order ordToCheck { get; private set; }
        private int index = 0;
        private bool visit = false;

        // methods
        public void Visit(Store StoreName)
        {
            Console.WriteLine($"You are now visiting the {StoreName.Name}");
            Console.WriteLine();
            StoreName.ShowCars();
            Console.WriteLine();
            Console.Write("Choose a car by it's index: ");
            index = Convert.ToInt32(Console.ReadLine());
            
        }

        public void Order(Store StoreName)
        {
            if (visit == false)
            {
                List<Car> cars = StoreName.AccessCarList();
                Order Ord = new Order(cars[index]);
                Console.WriteLine();
                Console.WriteLine($"You just ordered: {cars[index].Brand} - {cars[index].Model} - {cars[index].FabYear} - {cars[index].Price} euro.");
                Console.WriteLine($"The order will arrive in {Ord.TimeUponDelivery} days.");
                Console.WriteLine();
                ordToCheck = Ord;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You already made an order from another store.\nDo you agree on changing it?");
                string check = Console.ReadLine();
                if(check.ToLower()=="yes")
                {
                    List<Car> cars = StoreName.AccessCarList();
                    Order Ord = new Order(cars[index]);
                    Console.WriteLine("The other order was canceled.");
                    Console.WriteLine();
                    Console.WriteLine($"You just ordered: {cars[index].Brand} - {cars[index].Model} - {cars[index].FabYear} - {cars[index].Price} euro.");
                    Console.WriteLine($"The order will arrive in {Ord.TimeUponDelivery} days.");
                    Console.WriteLine();
                    ordToCheck = Ord;
                }

            }
            visit = true;
        }

        public void CheckCar()
        {
            if (ordToCheck.Car.RandomDeffect == 1)
                Console.WriteLine($"It will take 2 days for {ordToCheck.Car.Brand} Store to fix the problem");
            else
                Console.WriteLine("The car has no issues.");
        }


    }
}
