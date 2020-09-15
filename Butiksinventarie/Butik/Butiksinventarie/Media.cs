using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Butiksinventarie
{
    public abstract class Media
    {
        private string name;
        private double rating;
        private int releaseDate;
        private double price;
        private string creator;

        public string Name { get; set; }
        public double Rating { get; set; }
        public int ReleaseDate { get; set; }
        public double Price { get; set; }
        public string Creator { get; set; }
        public double RunTime { get; set; }


    }
}
