using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparesDealerApp
{
    class Worker
    {

        //Creating an instance of the Worker Class, the class contains a List of type Vehicle.
        private static Worker instance;


        //Only one of these lists are allowed to be created via the Singleton
        public static List<Vehicle> vehicles = new List<Vehicle>();

        
        //A private Constructor 
        private Worker() { }

       

        //So basically in this method I have an instance of the worker class which contains and stores the List of Vehicle Spares, so this method thats the instance variable
        //and checks if the instance exists and if it is null then the instance of the worker class is created which can add Vehicles to the list
        public static Worker GetInstance()
        {
            if (instance == null)
            {
                instance = new Worker();
            }

            return instance;
        }

        public void availableVehicleSpares(Vehicle v) {

            vehicles.Add(v);

        }


    }
}
