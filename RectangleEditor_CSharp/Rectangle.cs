using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_CSharp {
	class Rectangle {
		private int width;
		private int height;
		private int x;
		private int y;
		private int color;

		public Rectangle(int width, int height, int x, int y, int color) {
			this.width = width;
			this.height = height;
			this.x = x;
			this.y = y;
			this.color = color;
		}

		public void showRectAttribute() {
			Console.WriteLine("幅: {0}, 高さ: {1}, x座標: {2}, y座標: {3}, 色: {4}\n", width,height,x,y,color);
		}

		public int[] getAttribute() {
			int[] attribute = new int[5];

			attribute[0] = this.width;
			attribute[1] = this.height;
			attribute[2] = this.x;
			attribute[3] = this.y;
			attribute[4] = this.color;

			return attribute;
		}

		public void setAttribute(int[] attribute) {
			this.width = attribute[0];
			this.height = attribute[1];
			this.x = attribute[2];
			this.y = attribute[3];
			this.color = attribute[4];
		}

		public bool isSegment() {
			return this.width == 0 && this.height > 0 || this.width > 0 && this.height == 0;
		}

		public bool isPoint() {
			return this.width == 0 && this.height == 0;
		}

		public bool isNegative() {
			return this.width < 0 || this.height < 0 || this.x < 0 || this.y < 0;
		}
	}
}
