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

		//引数の座標が長方形の範囲内にあるならtrue
		public bool isContain(int x, int y) {
			if(x<this.X || x > this.X + Width) {
				return false;
			}
			if(y < this.Y || y > this.Y + Height) {
				return false;
			}
			return true;
		}

		//引数の座標が長方形の範囲外にあるならtrue
		public bool isNotContain(int x, int y) {
			if(x<this.X || x > this.X+Width) {
				return true;
			}
			if(y<this.Y || y >this.Y + Height) {
				return true;
			}
			return false;
		}

		//面積を返す
		public int calArea() {
			return Width * Height;
		}
	}
}
