using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Butiksinventarie
{
    public abstract class Media
    {
            public string Name;
            public double AverageRating;
            public int ReleaseDate;
            public abstract double RunTime();
            public double Price;
            public string Creator;

    }
}
