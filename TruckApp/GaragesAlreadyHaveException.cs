using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    class GaragesAlreadyHaveException : Exception
    {
        public GaragesAlreadyHaveException() : base("There is already such a car in the parking lot")
        { }
    }
}
