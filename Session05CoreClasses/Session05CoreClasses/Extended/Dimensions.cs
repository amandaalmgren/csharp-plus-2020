using System;
using System.Collections.Generic;
using System.Text;

namespace Session05CoreClasses
{
    public struct Dimensions
    {
        public readonly int Width;
        public readonly int Height;
        public readonly int Depth;

        //skapar konstruktor som tar emot parametrarna width, height och depth
        public Dimensions(int width, int height, int depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

    }
}
