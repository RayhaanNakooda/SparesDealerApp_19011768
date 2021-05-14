using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparesDealerApp
{
   public class Vehicle
    {

        private string model;
        private string make;
        private double price;
        private int numSold;

        public Vehicle(int numSold)
        {
            this.numSold = numSold;
        }

        public Vehicle(string model, string make, double price, int numSold)
        {
            this.model = model;
            this.make = make;
            this.price = price;
            this.numSold = numSold;
        }


        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }
        public double Price { get => price; set => price = value; }
        public int NumSold { get => numSold; set => numSold = value; }
    }
}
