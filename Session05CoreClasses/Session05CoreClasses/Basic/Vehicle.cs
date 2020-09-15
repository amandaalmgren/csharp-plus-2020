using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses
{
    public class Vehicle

    //klassdefinition
    {
        //fält, lagrar data 
        //inget värde förns en instans skapas
        public int VINnumber;
        public int PassangerSeats;
        public string RegistrationNumber;
        public int Wheels;

        //metoder
        public bool isVINValid()
        {
            //tar fältvärdet, kontrollerar om värdet > 0
            return VINnumber > 0;
        }
    }
}
