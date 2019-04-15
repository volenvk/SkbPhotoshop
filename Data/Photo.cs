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
}

