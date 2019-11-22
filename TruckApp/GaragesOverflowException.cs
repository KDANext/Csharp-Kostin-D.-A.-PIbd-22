using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckApp
{
    class GaragesOverflowException : Exception
    {
        public GaragesOverflowException() : base("No parking spaces available!") 
        { }
    }
}
