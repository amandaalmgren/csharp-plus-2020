﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Session05Animals
{
    public abstract class Animal
    {

        //Abstrakt metoddefinition
        public abstract void EatFood();

        //Konkret metoddefinition
        public void Breed() 
        {
            /*This implementation does nothing */
        }

    }
}
