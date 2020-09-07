using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Example01
{
    class CupOfCoffee
    {
        //statiskt fält, delas för hela klassen
        public static string DeafultBeanType = "Arabica";
        public static string[] BeanTypes;
        



        public string BeanType;
        public bool Instant;
        public bool Milk;
        public byte SugarCubes;
        public string Description;

        private string _id;

        static CupOfCoffee() // statisk konstruktor
        {
            BeanTypes = new[]
            {
                "Arusha",
                "Arabica",
                "Blue Mountain",
                "Robusta"
            }; //instruktion, tilldela värden till objekt därför avslutas med ; 
        }

        public CupOfCoffee() //konstruktor, alltid identisk med klassnamnet
        {

        }

        public CupOfCoffee(bool milk, byte sugarCubes) //konstruktor med inparametrar
        {
            SugarCubes = sugarCubes;
            Milk = milk;
        }

        ~CupOfCoffee() //finalizer eller destruktor (använd ej, bara veta att den finns)
        {

        }

    }
}
