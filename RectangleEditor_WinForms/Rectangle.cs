using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_WinForms {
	public class Rectangle {
		public int Width { get; set; }
		public int Height { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int Color { get; set; }

		public Rectangle(int width, int height, int x, int y, int color) {
			this.Width = width;
			this.Height = height;
			this.X = x;
			this.Y = y;
			this.Color = color;
		}

		public bool isSegment() {
			return this.Width == 0 && this.Height > 0 || this.Width > 0 && this.Height == 0;
		}

		public bool isPoint() {
			return this.Width == 0 && this.Height == 0;
		}

		public bool isNegative() {
			return this.Width < 0 || this.Height < 0 || this.X < 0 || this.Y < 0;
		}
	}
}
