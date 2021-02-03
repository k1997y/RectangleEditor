﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_GUI.Models {
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

		public void showRectAttribute() {
			Console.Write("幅: {0}, 高さ: {1}, x座標: {2}, y座標: {3}, 色: {4}\n", Width, Height, X, Y, Color);
		}

		public int[] getAttribute() {
			int[] attribute = new int[5];

			attribute[0] = this.Width;
			attribute[1] = this.Height;
			attribute[2] = this.X;
			attribute[3] = this.Y;
			attribute[4] = this.Color;

			return attribute;
		}

		public void setAttribute(int[] attribute) {
			this.Width = attribute[0];
			this.Height = attribute[1];
			this.X = attribute[2];
			this.Y = attribute[3];
			this.Color = attribute[4];
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
