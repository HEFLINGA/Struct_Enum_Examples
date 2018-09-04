using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsEnumsExamples
{
    // enums
    enum Color { Black, Blue, Red, NeonGreen, Grey };
    enum VehicleType { Car, Truck, Motorcycle };

    // struct class (value type INSTEAD of reference type)
    struct Vehicle
    {
        public VehicleType type;
        public Color color;

        public string make;
        public string model;
        public int year;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Used struct classes value types to instantiate a new Vehicle
            var porsche924s = 
                new Vehicle { type  = VehicleType.Car
                            , color = Color.Red
                            , make  = "Porsche"
                            , model = "924S"
                            , year  = 1987 };

            var nissan350z = 
                new Vehicle { type  = VehicleType.Car
                            , color = Color.Grey
                            , make  = "Nissan"
                            , model = "350Z"
                            , year  = 2008 };

            // Avoided putting WriteLine Inside of my below method, and instead put it here and used var in the method to make string.
            
            Console.WriteLine(MyFirstVehicleMessage(porsche924s));

            // !CAN! use enums in a switch statement!!
            switch (nissan350z.color)
            {
                case Color.Grey:
                    Console.WriteLine(MyFirstVehicleMessage(nissan350z));
                    break;
            };
        }

        // Place WriteLines outside of methods if possible
        private static string MyFirstVehicleMessage(Vehicle firstVehicle)
        {
            var msg = $"My first vehicle was a " +
                $"{firstVehicle.type}, specifcally a " +
                $"{firstVehicle.color} " +
                $"{firstVehicle.year} " +
                $"{firstVehicle.make} " +
                $"{firstVehicle.model}.";

            return msg;
        }
    }
}
