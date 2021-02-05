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

		public void expand_shrinkCmd(int index,double widthScale,double heightScale) {
			Rectangle r = board.getRect(index);

			r.Width = (int)Math.Round(r.Width*widthScale);
			r.Height = (int)Math.Round(r.Height * heightScale);

			board.replaceRect(r, index);
		}

		
		public void intersectCmd(HashSet<int> selected) {
			Rectangle r1 = new Rectangle();
			Rectangle r2 = new Rectangle();

			int i = 0;
			foreach(int index in selected) {
				if (i == 0) {
					r1 = board.getRect(index);
				}
				if(i == 1) {
					r2 = board.getRect(index);
				}
				i++;
			}



			if (r1.hasIntersect(r2)) {
				int width = 0;
				int height = 0;
				int x = 0;
				int y = 0;
				int color = 0;

				//幅を決定
				if (r1.X > r2.X) {
					width = (r2.X + r2.Width) - (r1.X);
					x = r1.X;
				}else if(r1.X+r1.Width > r2.X) {
					width = (r1.X + r1.Width) - (r2.X);
					x = r2.X;
				}

				//高さを決定
				if (r1.Y > r2.Y) {
					height = (r2.Y + r2.Height) - (r1.Y);
					y = r1.Y;
				} else if (r1.Y + r1.Height > r2.Y) {
					height = (r1.Y + r1.Height) - (r2.Y);
					y = r2.Y;
				}

				//色の決定
				if(r1.Color == r2.Color) {
					color = 3;
				}
				//redとblueならmagenta
				else if((r1.Color == 0 && r2.Color == 1) ||(r2.Color == 0 && r1.Color == 1)) {
					color = 4;
				}
				//redとyellowならorange
				else if ((r1.Color == 0 && r2.Color == 2) || (r2.Color == 0 && r1.Color == 2)) {
					color = 5;
				}
				//blueとyellowならgreen
				else if ((r1.Color == 1 && r2.Color == 2) || (r2.Color == 1 && r1.Color == 2)) {
					color = 6;
				}
				//それ以外ならcyan
				else {
					color = 7;
				}
				createCmd(width, height, x, y,color);
			}


		}

		public void deleteCmd(int index) {
			if (board.countRects() == 0) {
				return;
			}

			board.deleteRect(index);
		}

		public void deleteAllCmd() {
			if (board.countRects() == 0) {
				return;
			}
			board.clearBoard();
		}

		private Board board;
		public Board GetBoard {
			get { return board; }
		}
	}
}
