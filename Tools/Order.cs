using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class Order
    {
        // constructors
        public Order(Car car)
        {
            this.Car = car;
            Random random = new Random();
            this.Price = car.Price;
            this.TimeUponDelivery = random.Next(7, 15);
        }

        // fields
        public Car Car { get; private set; }
        public double Price { get; private set; }
        public int TimeUponDelivery { get; private set; }

    }
}
