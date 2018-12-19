using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    interface IStore
    {
        List<Car> AccessCarList();
        void ShowCars();
    }
}
