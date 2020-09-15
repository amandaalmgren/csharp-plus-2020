using System;
using System.Collections.Generic;

namespace OOPtest
{
    //basklass
    public class Creature
    {
        public int Power { get; set; }
        public int Toughness { get; set; }
        public string Type { get; set; }

        //public Creature(/*string type, int power, int toughness*/)
        //{
        //    Type = type;
        //    Power = power;
        //    Toughness = toughness;
        //}
        public void Attack()
        {
            Console.WriteLine(Type + " attacks with power " + Power);
        }

    }
    //subklass
    class Knight : Creature
    {
        public Knight()
        {

            Power = 5;
            Toughness = 5;
        }

    }

    class Wizard : Creature
    {
        public Wizard()
        {
            Power = 7;
            Toughness = 3;
        }

    }
    class Program
    {
            static void Main(string[] args)
        {
            //var c = new Wizard();
            //Creature creature = c;

            //    object o = new Creature("Knight", 5, 5);
            //    if(o is Creature)
            //    {
            //        Console.WriteLine("Creauture!");
            //        Creature c = o as Creature; //cast
            //        c.Attack();
            //    }

            //if(knight is Creature)
            //    Console.WriteLine("Knight är en creature!");



            //Utan arv
            //List<Creature> creatures = new List<Creature>();
            //creatures.Add(new Creature("Knight", 5, 5));
            //creatures.Add(new Creature("Wizard", 7, 3));

            //foreach (var c in creatures)
            //{
            //    c.Attack();
            //}

            Creature wizard = new Wizard();
            Creature knight = new Knight();

            wizard.Attack();
            knight.Attack();

            Console.ReadKey();
        }
    }
}
