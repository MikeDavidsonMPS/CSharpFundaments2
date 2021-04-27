using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();                 //ITS IMPORTANT to understand that test is for a "batch of cookies" == the word "cookie" is just describing what the "name" of the valuable will be
            cookie.Name = "Snickerdoodle";
            cookie.HasNut = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "Something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoole = new Cookie("snickerdoole", false, 11.5);      // with in the parameters we have assign an argument 
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);

        }
        [TestMethod]
        public void VechicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle                        // instead of using "()" we will use "{}" and place ";" on the outside of "}"  line 23 
            {
                TypeOfVehicle = VehicleType.Motorcycle,           //  object ititialation syntax:   it allow the parameter to open up to a choices that we want to make Ex from line 30 new vehicle 
                Make = "Honda",
                Model= "Civic"
            };
        }
    }
}
