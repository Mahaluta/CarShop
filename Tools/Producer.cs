using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class Producer
    {
        // constructors
        public Producer(string BrandName)
        {
            this.Brand = BrandName;
        }

        // fields
        public string Brand { get; private set; }
    }
}
