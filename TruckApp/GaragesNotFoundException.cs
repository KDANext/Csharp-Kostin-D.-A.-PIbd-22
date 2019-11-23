using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    class GaragesNotFoundException : Exception
    {
        public GaragesNotFoundException(int i) : 
            base("No truck found by location" + i) 
        { }
    }
}
