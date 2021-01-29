using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_CSharp {
	class Command {
		public Command() { }

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

		public void createCmd() {
			int w, h, x, y, color;

			Console.Write("横幅を入力\n-->");
			w = inputInt();
			Console.Write("縦幅を入力\n-->");
			h = inputInt();
			Console.Write("左上のx座標を入力\n-->");
			x = inputInt();
			Console.Write("左上のy座標を入力\n-->");
			y = inputInt();
			Console.Write("長方形の色を指定\n1: red\n2: blue\n3: yellow\n4: gray\n対応する色の番号を入力\n-->");
			color = inputInt();

			Rectangle r = new Rectangle(w, h, x, y, color);

			if (board.isDuplicating(r)) {
				Console.Write("長方形が重複しています\n");
			} else if (board.countRects() >= 10) {
				Console.Write("10個以上の長方形を配置することができません\n");
			} else {
				board.addRect(r);
				Console.Write("長方形がボード上に配置されました\n");
				displayBoardCmd();
			}
		}

		public void moveCmd() {
			int n;
			Console.Write("動かす長方形を指定してください\n-->");
			n = inputInt();

			Rectangle r = board.getRect(n - 1);

			int x, y;
			Console.Write("x方向の移動距離を入力\n-->");
			x = inputInt();
			Console.Write("y方向の移動距離を入力\n-->");
			y = inputInt();

			int[] attribute = new int[5];

			attribute = r.getAttribute();
			attribute[2] = attribute[2] + x;
			attribute[3] = attribute[3] + y;
			r.setAttribute(attribute);

			board.replaceRect(r, n);
			Console.Write("長方形{0}が移動されました\n", n);
			displayBoardCmd();
		}

		public void expand_shrinkCmd() {
			int n;
			Console.Write("拡大または縮小する長方形を指定してください\n-->");
			n = inputInt();

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

		public void intersectCmd() {

		}

		public void deleteCmd() {
			int n;
			if (board.countRects() == 0) {
				Console.Write("ボード上に長方形がありません\n");
				return;
			}

			displayBoardCmd();
			Console.Write("削除したい長方形を指定してください\n-->");
			n = int.Parse(Console.ReadLine());

			board.deleteRect(n);
			Console.Write("指定された長方形は削除されました\n");
			displayBoardCmd();
		}

		public void deleteAllCmd() {
			if (board.countRects() == 0) {
				Console.Write("ボード上に長方形がありません\n");
				return;
			}
			board.clearBoard();
			Console.Write("ボードがクリアされました\n");
		}

		public void displayBoardCmd() {
			if (board.countRects() == 0) {
				Console.Write("ボード上に長方形がありません\n");
			} else {
				for (int i = 0; i < board.countRects(); i++) {
					Rectangle r = board.getRect(i);
					Console.Write("{0}: ", i + 1);
					r.showRectAttribute();
				}
				Console.Write("\n");
			}
		}

		/*************************
		 * コマンドの説明を出力する関数群
		 ************************/
		public void createDescription() {
			Console.WriteLine("{0}: create...長方形を生成", (int)Commands.CREATE);
		}
		public void moveDescription() {
			Console.WriteLine("{0}: move...指定した長方形を移動", (int)Commands.MOVE);
		}
		public void expand_shrinkDescription() {
			Console.WriteLine("{0}: expand/shrink...指定した長方形のサイズ変更", (int)Commands.EXPAND_SHRINK);
		}
		public void intersectDescription() {
			Console.WriteLine("{0}: intersect...指定した2つの長方形の交差部分を新たな抽出", (int)Commands.INTERSECT);
		}
		public void deleteDescription() {
			Console.WriteLine("{0}: delete...指定した長方形を削除", (int)Commands.DELETE);
		}
		public void deleteAllDescription() {
			Console.WriteLine("{0}: deleteAll...ボード上の全ての長方形を削除", (int)Commands.DELETEALL);
		}
		public void displayBoardDescription() {
			Console.WriteLine("{0}: displayBoard...ボード上の長方形を表示", (int)Commands.DISPLAY);
		}
		public void exitDescription() {
			Console.WriteLine("{0}: exit...プログラムを終了", (int)Commands.EXIT);
		}

		private Board board;

		//ループを出るか出ないかのフラグ
		public bool isExit { get; set; }

		//入力処理(エラー処理も行う)
		private int inputInt() {
			int input;
			while (true) {
				try {
					input = int.Parse(Console.ReadLine());
					return input;
				} catch (FormatException e) {
					Console.WriteLine(e.Message);
					continue;
				}
			}
		}
	}
}
