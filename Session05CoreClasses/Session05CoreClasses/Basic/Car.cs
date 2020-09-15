using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses
{
    //ärva alla fält/egenskaper/metoder från Vehicle klassen
    public class Car : Vehicle
    {
        public string CarColor;

        public bool HasValidCarColor()
        {
            //kollar att strängvärdet är satt
            return string.IsNullOrEmpty(CarColor) == false;
        }
    }
}
