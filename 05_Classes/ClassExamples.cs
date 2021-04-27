using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Cookie
    {
        public string Name { get; set; }
        public bool HasNut { get; set; }
        public double GramsOfFlour { get; set; }

        public Cookie()                                                     //OverLoad Constructor - a blank constructor
        {                                                                   // this blank constructor allows us the option of making and emtpy objest ---parameter =="()"

        }

        public Cookie(string name, bool hasNuts, double gramsOfFlour)      //  Over Load constructive - which is loaded and simplifes line 11-13 to line 22-24
        {
            Name = name;                                                  // now we assign the propeties to our paratmeters
            HasNut = hasNuts;
            GramsOfFlour = gramsOfFlour;
        }
    }

    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat }   // "enum" can assign the properties that we want as a group

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public string Color { get; set; }
        public double Year { get; set; }
        public VehicleType TypeOfVehicle { get; set; }      // use and "emun" allows us to create our own "type", like string, bouble, bool,ect  this example are emun is VehicleType from line16


        public Vehicle()                   // OverLoad Blank Constructor
        {

        }
    }

    public class Order
    {
        public string CustomerName { get; set; }
        public Cookie OrderedProduct { get; set; }
        public decimal TotalCost { get; set; }

    }


}
