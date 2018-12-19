using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    interface ICustomer
    {
        void Visit(Store StoreName);
        void Order(Store StoreName);
        void CheckCar();
    }
}
