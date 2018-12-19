using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace CarShop
{
    class Program
    {
        static void Main(string[] args)
        {
           Store Audi = new Store("Audi Store","Iasi");     
           Store Tesla = new Store("Tesla Store","London"); 


            Console.Clear();

            Customer c1 = new Customer("Alex");
            c1.Visit(Audi);
            c1.Order(Audi);

            c1.Visit(Tesla);
            c1.Order(Tesla);

            c1.CheckCar();
        
            Console.ReadKey();
        }
    }
}
