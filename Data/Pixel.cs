using System;

namespace MyPhotoshop
{
    public struct Pixel
    {
        public readonly double R;

        public readonly double G;

        public readonly double B;

        public Pixel(double r, double g, double b)
        {
            if (r < 0 || r > 1 || g < 0 || g > 1 || b < 0 || b > 1)
                throw new Exception(string.Format("Wrong channel value (the value must be between 0 and 1"));

            R = r;
            G = g;
            B = b;
        }

        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return R;
                    case 1: return G;
                    case 2: return B;
                    default: return 0;
                }
            }
        }

        public static Pixel operator *(Pixel pixel, double value)
        {
            return new Pixel(pixel.R * value, pixel.G * value, pixel.B * value);
        }
    }
}
