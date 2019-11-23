using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    class GaragesOccupiedPlaceException : Exception
    {
        public GaragesOccupiedPlaceException(int i) : base("On the spot " + i + " car is already standing") 
        { }
    }
}
