using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleEditor_WinForms {
	public partial class RectangleEditor : Form {
		//[System.Runtime.InteropServices.DllImport("kernel32.dll")] // この行を追加
		//private static extern bool AllocConsole();                 // この行を追加 

		Command command;
		//選択された長方形のインデックスのセット
		HashSet<int> selectedRectsNumSet;

		public RectangleEditor() {
			InitializeComponent();
			command = new Command();
			selectedRectsNumSet = new HashSet<int>();

			//AllocConsole();

			//キャンバスの枠線を描く
			Bitmap bmp = canvas.Image as Bitmap;
			if (bmp != null) {
				bmp.Dispose();
			}
			bmp = new Bitmap(canvas.Width, canvas.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			canvas.Image = bmp;

			using var g = Graphics.FromImage(bmp);
			g.Clear(Color.White);
			g.DrawRectangle(Pens.Black, 0, 0, canvas.Width - 1, canvas.Height - 1);
		}

		/// <summary>
		/// createボタンが押されたときの挙動を定義する
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void createButton_Click(object sender, EventArgs e) {
			int width = 0;
			int height = 0;
			int x = 0;
			int y = 0;
			int color = 0;

			//どの色が選択されているかを判断する
			if (radioButton_red.Checked) {
				color = 0;
			} else if (radioButton_blue.Checked) {
				color = 1;
			} else if (radioButton_yellow.Checked) {
				color = 2;
			} else if (radioButton_gray.Checked) {
				color = 3;
			}

			try {
				width = int.Parse(textBox_width.Text);
				height = int.Parse(textBox_height.Text);
				x = int.Parse(textBox_x.Text);
				y = int.Parse(textBox_y.Text);
			} catch (FormatException exception) {
				System.Console.WriteLine(exception.Message);
			}

			try {
				command.createCmd(width, height, x, y, color);
			}catch(Exception exception) {
				MessageBox.Show(exception.Message,"エラー",MessageBoxButtons.OK,MessageBoxIcon.Stop);
			}
				DrawRects();
		}

		/// <summary>
		/// moveボタンが押されたときの挙動を定義する
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void moveButton_Click(object sender, EventArgs e) {
			int dx = 0;
			int dy = 0;

			try {
				dx = int.Parse(textBox_dx.Text);
				dy = int.Parse(textBox_dy.Text);
			} catch (FormatException exception) {
				System.Console.WriteLine(exception.Message);
			}

			foreach (int index in selectedRectsNumSet) {
				command.moveCmd(index, dx, dy);
			}
			DrawRects();

		}

		/// <summary>
		/// expand/shrinkボタンが押されたときの挙動を定義する
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void expandShrinkButton_Click(object sender, EventArgs e) {
			double widthScale = 0.0;
			double heightScale = 0.0;

			try {
				widthScale = double.Parse(textBox_widthScale.Text);
				heightScale = double.Parse(textBox_heightScale.Text);
			} catch (FormatException exception) {
				System.Console.WriteLine(exception.Message);
			}

			foreach (int index in selectedRectsNumSet) {
				command.expand_shrinkCmd(index, widthScale, heightScale);
			}
			DrawRects();
		}

		/// <summary>
		/// intersectボタンが押されたときの挙動を定義する
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void intersectButton_Click(object sender, EventArgs e) {
			//選択数が2個以外の場合は実行しない
			if(selectedRectsNumSet.Count != 2) {
				return;
			}
			command.intersectCmd(selectedRectsNumSet);

			DrawRects();
		}

		/// <summary>
		/// deleteボタンが押されたときの挙動を定義する
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteButton_Click(object sender, EventArgs e) {
			foreach (int index in selectedRectsNumSet) {
				command.deleteCmd(index);
			}
			DrawRects();
		}

		/// <summary>
		/// deleteAllボタンが押されたときの挙動を定義する
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteAllButton_Click(object sender, EventArgs e) {
			command.deleteAllCmd();
			DrawRects();
		}

		/// <summary>
		/// キャンバスがクリックされたときの挙動を定義する
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void canvas_MouseClick(object sender, MouseEventArgs e) {
			List<Rectangle> onBoardRects = command.GetBoard.OnBoardRects;
			if (command.GetBoard.countRects() == 0) {
				return;
			}

			int index = 0;
			if (command.GetBoard.isNotContain(e.X,e.Y)) {
				selectedRectsNumSet.Clear();
				DrawRects();
				return;
			}
			foreach (RectangleEditor_WinForms.Rectangle r in onBoardRects) {
				if (r.isContain(e.X, e.Y)) {
						selectedRectsNumSet.Add(index);
					
					//面積がより小さい方を選択された長方形とみなす
					//else if (selectedRect.calArea() > r.calArea()) {
					//	selectedRect = r;
					//	selectedRectNum = index;
					//}
				}
				index++;
			}


			Bitmap bmp = canvas.Image as Bitmap;
			if (bmp != null) {
				bmp.Dispose();
			}
			bmp = new Bitmap(canvas.Width, canvas.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			canvas.Image = bmp;

			//選択された長方形を強調する
			using var g = Graphics.FromImage(bmp);
			g.Clear(Color.White);

			index = 0;
			foreach (RectangleEditor_WinForms.Rectangle r in onBoardRects) {
				if (selectedRectsNumSet.Contains(index)) {
					index++;
					continue;				
				} else {
					switch (r.Color) {
						case Rectangle.Colors.RED:
							g.FillRectangle(Brushes.Red, r.X, r.Y, r.Width, r.Height);
							break;
						case Rectangle.Colors.BLUE:
							g.FillRectangle(Brushes.Blue, r.X, r.Y, r.Width, r.Height);
							break;
						case Rectangle.Colors.YELLOW:
							g.FillRectangle(Brushes.Yellow, r.X, r.Y, r.Width, r.Height);
							break;
						case Rectangle.Colors.GRAY:
							g.FillRectangle(Brushes.Gray, r.X, r.Y, r.Width, r.Height);
							break;
						case Rectangle.Colors.MAGENTA:
							g.FillRectangle(Brushes.Magenta, r.X, r.Y, r.Width, r.Height);
							break;
						case Rectangle.Colors.ORANGE:
							g.FillRectangle(Brushes.Orange, r.X, r.Y, r.Width, r.Height);
							break;
						case Rectangle.Colors.GREEN:
							g.FillRectangle(Brushes.Green, r.X, r.Y, r.Width, r.Height);
							break;
						case Rectangle.Colors.CYAN:
							g.FillRectangle(Brushes.Cyan, r.X, r.Y, r.Width, r.Height);
							break;
					}
				}
				index++;
			}

			//半透明で選択された長方形を描く
			Color c;
			foreach (int i in selectedRectsNumSet) {
				RectangleEditor_WinForms.Rectangle r = command.GetBoard.getRect(i);

				switch (r.Color) {
					case Rectangle.Colors.RED:
						c = Color.FromArgb(50, Color.Red);
						break;
					case Rectangle.Colors.BLUE:
						c = Color.FromArgb(50, Color.Blue);
						break;
					case Rectangle.Colors.YELLOW:
						c = Color.FromArgb(50, Color.Yellow);
						break;
					case Rectangle.Colors.GRAY:
						c = Color.FromArgb(50, Color.Gray);
						break;
					case Rectangle.Colors.MAGENTA:
						c = Color.FromArgb(50, Color.Magenta);
						break;
					case Rectangle.Colors.ORANGE:
						c = Color.FromArgb(50, Color.Orange);
						break;
					case Rectangle.Colors.GREEN:
						c = Color.FromArgb(50, Color.Green);
						break;
					case Rectangle.Colors.CYAN:
						c = Color.FromArgb(50, Color.Cyan);
						break;
					default:
						return;
				}
				SolidBrush sb = new SolidBrush(c);
				g.FillRectangle(sb, r.X, r.Y, r.Width, r.Height);
			}
			canvas.Refresh();

		}


		//ボード上の長方形を描画する
		private void DrawRects() {
			List<Rectangle> onBoardRects = command.GetBoard.OnBoardRects;

			Bitmap bmp = canvas.Image as Bitmap;
			if (bmp != null) {
				bmp.Dispose();
			}
			bmp = new Bitmap(canvas.Width, canvas.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			canvas.Image = bmp;

			using var g = Graphics.FromImage(bmp);
			g.Clear(Color.White);
			foreach (RectangleEditor_WinForms.Rectangle r in onBoardRects) {
				switch (r.Color) {
					case Rectangle.Colors.RED:
						g.FillRectangle(Brushes.Red, r.X, r.Y, r.Width, r.Height);
						break;
					case Rectangle.Colors.BLUE:
						g.FillRectangle(Brushes.Blue, r.X, r.Y, r.Width, r.Height);
						break;
					case Rectangle.Colors.YELLOW:
						g.FillRectangle(Brushes.Yellow, r.X, r.Y, r.Width, r.Height);
						break;
					case Rectangle.Colors.GRAY:
						g.FillRectangle(Brushes.Gray, r.X, r.Y, r.Width, r.Height);
						break;
					case Rectangle.Colors.MAGENTA:
						g.FillRectangle(Brushes.Magenta, r.X, r.Y, r.Width, r.Height);
						break;
					case Rectangle.Colors.ORANGE:
						g.FillRectangle(Brushes.Orange, r.X, r.Y, r.Width, r.Height);
						break;
					case Rectangle.Colors.GREEN:
						g.FillRectangle(Brushes.Green, r.X, r.Y, r.Width, r.Height);
						break;
					case Rectangle.Colors.CYAN:
						g.FillRectangle(Brushes.Cyan, r.X, r.Y, r.Width, r.Height);
						break;
				}
			}
			canvas.Refresh();
		}
	}
}


