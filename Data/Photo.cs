using System;
using System.Collections.Generic;

namespace MyPhotoshop
{
	public class Photo
	{ 
		public readonly int Width;
		public readonly int Height;
		private readonly Pixel[,] data;

		public Pixel this[int x, int y]
		{
			get
			{
				if (x > Width || y > Height || x < 0 || y < 0) 
					throw new ArgumentException("x or y set mistake");
				return data[x,y];
			}
			set
			{
				if (x > Width || y > Height || x < 0 || y < 0)
					throw new ArgumentException("x or y set mistake");

				data[x, y] = value;
			}
		}

		public Photo(int width, int height)
		{
			Width = width;
			Height = height;
			data = new Pixel[width, height];
		}
	}

	public struct Pixel
	{
		public readonly int X;
		
		public readonly int Y;
		
		private readonly Color color;
		
		public double R => color.R;

		public double G => color.G;

		public double B => color.B;
		
		public Pixel(int x, int y, Color color)
		{
			X = x;
			Y = y;
			this.color = color;
		}
	
		public static Pixel operator *(Pixel pixel, double value)
		{
			var color = new Color(pixel.R * value, pixel.G * value, pixel.B * value);
			var data = new Pixel(pixel.X, pixel.Y, color);
			return data;
		}
	}

	public struct Color
	{
		public readonly double R;

		public readonly double G;

		public readonly double B;

		public Color(double r, double g, double b)
		{
			if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
				throw new ArgumentOutOfRangeException();
			
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
	}
}

