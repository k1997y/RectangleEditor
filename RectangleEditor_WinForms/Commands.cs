using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_WinForms {
	public class Command {
		public Command() {
			this.board = new Board();
		}

		public enum Commands {
			CREATE,
			MOVE,
			EXPAND_SHRINK,
			INTERSECT,
			DELETE,
			DELETEALL,
			DISPLAY,
			EXIT
		};

		public void createCmd(int width,int height,int x,int y,int color) {
			Rectangle r = new Rectangle(width, height, x, y, color);

			if (board.isDuplicating(r)) {
				Console.Write("長方形が重複しています\n");
			} else if (board.countRects() >= 10) {
				Console.Write("10個以上の長方形を配置することができません\n");
			} else {
				board.addRect(r);
			}
		}

		public void moveCmd(int index,int dx,int dy) {
			Rectangle r = board.getRect(index);

			r.X += dx;
			r.Y += dy;

			board.replaceRect(r, index);
		}

		public void expand_shrinkCmd() {
			Rectangle r = board.getRect(n - 1);

			double mx, my;
			Console.Write("幅の拡大縮小率を入力\n-->");
			mx = double.Parse(Console.ReadLine());
			Console.Write("y方向の移動距離を入力\n-->");
			my = double.Parse(Console.ReadLine());

			int[] attribute = new int[5];

			attribute = r.getAttribute();
			attribute[0] = (int)Math.Round(attribute[0] * mx);
			attribute[1] = (int)Math.Round(attribute[1] * my);
			r.setAttribute(attribute);

			board.replaceRect(r, n);
			Console.Write("長方形{0}が移動されました\n", n);
			displayBoardCmd();
		}

		//public void intersectCmd() {

		//}

		//public void deleteCmd() {
		//	int n;
		//	if (board.countRects() == 0) {
		//		Console.Write("ボード上に長方形がありません\n");
		//		return;
		//	}

		//	displayBoardCmd();
		//	Console.Write("削除したい長方形を指定してください\n-->");
		//	n = int.Parse(Console.ReadLine());

		//	board.deleteRect(n);
		//	Console.Write("指定された長方形は削除されました\n");
		//	displayBoardCmd();
		//}

		//public void deleteAllCmd() {
		//	if (board.countRects() == 0) {
		//		Console.Write("ボード上に長方形がありません\n");
		//		return;
		//	}
		//	board.clearBoard();
		//	Console.Write("ボードがクリアされました\n");
		//}

		//public void displayBoardCmd() {
		//	if (board.countRects() == 0) {
		//		Console.Write("ボード上に長方形がありません\n");
		//	} else {
		//		for (int i = 0; i < board.countRects(); i++) {
		//			Rectangle r = board.getRect(i);
		//			Console.Write("{0}: ", i + 1);
		//			r.showRectAttribute();
		//		}
		//		Console.Write("\n");
		//	}
		//}

		private Board board;
		public Board GetBoard {
			get { return board; }
		}
	}
}
