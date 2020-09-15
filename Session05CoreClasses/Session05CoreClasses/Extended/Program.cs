using Session05CoreClasses.Extended;
using System;

namespace Session05CoreClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //man kan tilldela alla datatyper som ärver från Vehicle i denna variabel
            //generellt sett används Car som datatyp
            Vehicle myVehicle = new Car(); 
            //exempel på boxing, packar ner datatypen i en låda vars innehåll glöms bort

            //tilldela värde 123 på fältet VINnumber
            myVehicle.VINnumber = 123;
            myVehicle.Wheels = 4;
            myVehicle.RegistrationNumber = "ABC123";

            //värdekonvertering som orsakar fel
            Car myCar = (Car)myVehicle; //tvingar den till Car, orsakar ett fel
            //exempel på unboxing, packar upp data ur en låda
            //generell datatyp till ? 05:09

            //värdekonvertering som blir null
            Car myNullableCar = myVehicle as Car;

            //Sätta det specifika fältet CarColor till ett värde
            myCar.CarColor = "Brown";
            myCar.PassangerSeats = 4;
            //kommer ej åt generella datatypen
            //myVehicle.CarColor

            //Skapa avancerade objekt
            Position lampPosition = new Position(0, 0);
            Dimensions lampDimensions = new Dimensions(300, 400, 250);
            string lampBulbType = "Incandescent";

            //Skapa instanser med komplexa objekt
            Furniture myFurniture = new Lamp(lampDimensions, lampPosition, lampBulbType);
            Lamp myLamp = (Lamp)myFurniture;

            //Komma åt egenskaper under objekt
            int lampWidth = myLamp.Dimensions.Width;
            int lampHeight = myLamp.Dimensions.Height;
        }


    }
}
