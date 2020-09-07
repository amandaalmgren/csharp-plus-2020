using Session05Animals;
using System;

namespace Session05Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            var beanType = CupOfCoffee.DeafultBeanType;

            Animal myAnimal = new Chicken(1);
            myAnimal = new Cow(2);


            Cow myCow = (Cow)myAnimal; //Casting, tvingar variabeln att bli en cow = tvingad datakonvertering
            //Genrerar InvalidCastException

            myCow = myAnimal as Cow; //säker datakonvertering
            //blir null om typen inte går att konvertera

            IBarnyardAnimal myBarnyardAnimal = new Chicken(1);
            myBarnyardAnimal.FeedingArea = "Main yard";

            myAnimal = (Animal)myBarnyardAnimal;

            Chicken myChicken = new Chicken(1);

            
        }
    }
}
