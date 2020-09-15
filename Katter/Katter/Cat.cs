using System;
using System.Collections.Generic;
using System.Text;

namespace Katter
{
    public class Cat
    {
        public string name;
        public int age;
        public string color;

        public string Name { get { return name; } }
        public int Age { get { return age; } }
        public string Color { get { return color; } }

        public Cat(string inName, int inAge, string inColor)
        {
            name = inName;
            age = inAge;
            color = inColor;
        }

    }
}
