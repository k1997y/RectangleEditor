using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_WinForms {
	public class Rectangle {
		public int Width { get; set; }
		public int Height { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		//public int Color { get; set; }
		public Colors Color { get; set; }

		//public Rectangle(int width, int height, int x, int y, int color) {
		//	this.Width = width;
		//	this.Height = height;
		//	this.X = x;
		//	this.Y = y;
		//	this.Color = color;
		//}
		public Rectangle(int width,int height ,int x, int y, int color) {
			this.Width = width;
			this.Height = height;
			this.X = x;
			this.Y = y;
			this.Color = (Colors)color;
		}

		public Rectangle() { }

		public enum Colors {
			RED,
			BLUE,
			YELLOW,
			GRAY,
			MAGENTA,
			ORANGE,
			GREEN,
			CYAN
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

		//引数の座標が長方形の範囲内にあるならtrue
		public bool isContain(int x, int y) {
			if (x < this.X || x > this.X + Width) {
				return false;
			}
			if (y < this.Y || y > this.Y + Height) {
				return false;
			}
			return true;
		}

		//引数の座標が長方形の範囲外にあるならtrue
		public bool isNotContain(int x, int y) {
			if (x < this.X || x > this.X + Width) {
				return true;
			}
			if (y < this.Y || y > this.Y + Height) {
				return true;
			}
			return false;
		}

		public bool hasIntersect(Rectangle r) {
			return Math.Abs(this.X - r.X) < this.Width / 2 + r.Width / 2
				&& Math.Abs(this.Y - r.Y) < this.Height / 2 + r.Height / 2;
		}

		//面積を返す
		public int calArea() {
			return Width * Height;
		}

		
		public static bool operator==(Rectangle r1,Rectangle r2) {
			if (r1.Width != r2.Width) return false;
			if (r1.Height != r2.Height) return false;
			if (r1.X != r2.X) return false;
			if (r1.Y != r2.Y) return false;
			return true;
		}
		public static bool operator !=(Rectangle r1, Rectangle r2) {
			if (r1.Width == r2.Width) return false;
			if (r1.Height == r2.Height) return false;
			if (r1.X == r2.X) return false;
			if (r1.Y == r2.Y) return false;
			return true;
		}
	}
}
