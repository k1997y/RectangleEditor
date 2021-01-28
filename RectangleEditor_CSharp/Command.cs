using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_CSharp {
	class Command {
		Command() {
			isExit = false;
		}

		public enum command {
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

			Console.WriteLine("横幅を入力\n-->");
			w = inputInt();
			Console.WriteLine("縦幅を入力\n-->");
			h = inputInt();
			Console.WriteLine("左上のx座標を入力\n-->");
			x = inputInt();
			Console.WriteLine("左上のy座標を入力\n-->");
			y = inputInt();
			Console.WriteLine("長方形の色を指定\n1: red\n2: blue\n3: yellow\n4: gray\n対応する色の番号を入力\n-->");
			color = inputInt();

			Rectangle r = new Rectangle(w, h, x, y, color);

			if (board.isDuplicating(r)) {
				Console.WriteLine("長方形が重複しています\n");
			}else if(board.countRects() >= 10) {
				Console.WriteLine("10個以上の長方形を配置することができません\n");
			} else {
				board.addRect(r);
				Console.WriteLine("長方形がボード上に配置されました\n");
				displayBoardCmd();
			}
		}

		public void moveCmd() {
			int n;
			Console.WriteLine("動かす長方形を指定してください\n-->");
			n = inputInt();

			Rectangle r = board.getRect(n - 1);

			int x, y;
			Console.WriteLine("x方向の移動距離を入力\n-->");
			x = inputInt();
			Console.WriteLine("y方向の移動距離を入力\n-->");
			y = inputInt();

			int[] attribute = new int[5];

			attribute = r.getAttribute();
			attribute[2] = attribute[2] + x;
			attribute[3] = attribute[3] + y;
			r.setAttribute(attribute);

			board.replaceRect(r, n);
			Console.WriteLine("長方形%dが移動されました\n", n);
			displayBoardCmd();
		}

		public void expand_shrinkCmd() {
			int n;
			Console.WriteLine("拡大または縮小する長方形を指定してください\n-->");
			n = inputInt();

			Rectangle r = board.getRect(n - 1);

			double mx, my;
			Console.WriteLine("幅の拡大縮小率を入力\n-->");
			mx = double.Parse(Console.ReadLine());
			Console.WriteLine("y方向の移動距離を入力\n-->");
			my = double.Parse(Console.ReadLine());

			int[] attribute = new int[5];

			attribute = r.getAttribute();
			attribute[0] = (int)Math.Round(attribute[0] * mx);
			attribute[1] = (int)Math.Round(attribute[1] * my);
			r.setAttribute(attribute);

			board.replaceRect(r, n);
			Console.WriteLine("長方形%dが移動されました\n", n);
			displayBoardCmd();
		}

		public void intersectCmd() {

		}

		public void deleteCmd() {
			int n;
			if(board.countRects() == 0) {
				Console.WriteLine("ボード上に長方形がありません\n");
				return;
			}

			displayBoardCmd();
			Console.WriteLine("削除したい長方形を指定してください\n-->");
			n = int.Parse(Console.ReadLine());

			board.deleteRect(n);
			Console.WriteLine("指定された長方形は削除されました\n");
			displayBoardCmd();
		}

		public void deleteAllCmd() {
			if(board.countRects() == 0) {
				Console.WriteLine("ボード上に長方形がありません\n");
				return;
			}
			board.clearBoard();
			Console.WriteLine("ボードがクリアされました\n");
		}

		public void displayBoardCmd() {
			if (board.countRects() == 0) {
				Console.WriteLine("ボード上に長方形がありません\n");
			} else {
				for (int i = 0; i < board.countRects(); i++) {
					Rectangle r = board.getRect(i);
					Console.WriteLine("%d: ", i + 1);
					r.showRectAttribute();
				}
				Console.WriteLine("\n");
			}
		}

		public void exitMsg() {
			isExit = true;
		}

		/*************************
		 * コマンドの説明を出力する関数群
		 ************************/
		public void createDescription() {
			Console.WriteLine("%d: create...長方形を生成\n",(int)command.CREATE);
		}
		public void moveDescription() {
			Console.WriteLine("%d: move...指定した長方形を移動\n",(int)command.MOVE);
		}
		public void expand_shrinkDescription() {
			Console.WriteLine("%d: expand/shrink...指定した長方形のサイズ変更\n",(int)command.EXPAND_SHRINK);
		}
		public void intersectDescription() {
			Console.WriteLine("%d: intersect...指定した2つの長方形の交差部分を新たな抽出\n", (int)command.INTERSECT);
		}
		public void deleteDescription() {
			Console.WriteLine("%d: delete...指定した長方形を削除\n", (int)command.DELETE);
		}
		public void deleteAllDescription() {
			Console.WriteLine("%d: deleteAll...ボード上の全ての長方形を削除\n", (int)command.DELETEALL);
		}
		public void displayBoardDescription() {
			Console.WriteLine("%d: displayBoard...ボード上の長方形を表示\n", (int)command.DISPLAY);
		}
		public void exitDescription() {
			Console.WriteLine("%d: exit...プログラムを終了\n", (int)command.EXIT);
		}

		private Board board;
		
		//ループを出るか出ないかのフラグ
		private bool isExit;

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
