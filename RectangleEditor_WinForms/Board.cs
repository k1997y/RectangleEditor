using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_WinForms {
	public class Board {
		public Board() {
			onBoardRects = new List<Rectangle>();
		}

		public void addRect(Rectangle r) {
			onBoardRects.Add(r);
		}

		//indexの場所に存在する長方形をrで置換する
		public void replaceRect(Rectangle r, int index) {
			onBoardRects[index] = r;
		}

		//ボード上の長方形の個数を返す
		public int countRects() {
			return onBoardRects.Count;
		}

		public Rectangle getRect(int index) {
			return onBoardRects[index];
		}

		public void deleteRect(int index) {
			onBoardRects.RemoveAt(index);
		}

		public void clearBoard() {
			onBoardRects.Clear();
		}

		public bool isDuplicating(Rectangle r) {
			foreach(Rectangle rect in onBoardRects) {
				if(rect == r) {
					return true;
				}
			}
			return false;
		}

		//ボード上のある点が長方形に含まれない場合にtrue
		public bool isNotContain(int x, int y) {
			List<Rectangle> rects = OnBoardRects;

			foreach(Rectangle r in rects) {
				if (r.isContain(x,y)) {
					return false;
				}
			}
			return true;
		}

		private const int WIDTH = 500;
		private const int HEIGHT = 400;

		private List<Rectangle> onBoardRects;
		public List<Rectangle> OnBoardRects {
			get { return onBoardRects; }
		}
	}
}
