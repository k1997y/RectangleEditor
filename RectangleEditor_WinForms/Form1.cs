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
	public partial class Form1 : Form {
		Command command;
		RectangleEditor_WinForms.Rectangle selectedRect;	//クリックで選択された長方形

		public Form1() {
			InitializeComponent();
			command = new Command();

			//キャンバスの枠線を描く
			Bitmap bmp = canvas.Image as Bitmap;
			if (bmp != null) {
				bmp.Dispose();
			}
			bmp = new Bitmap(canvas.Width, canvas.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			canvas.Image = bmp;

			using (var g = Graphics.FromImage(bmp)) {
				g.Clear(Color.White);
				g.DrawRectangle(Pens.Black, 0, 0, canvas.Width - 1, canvas.Height - 1);
			}
		}

		private void createButton_Click(object sender, EventArgs e) {
			int width = 0;
			int height = 0;
			int x = 0;
			int y = 0;
			int color = 0;

			//どの色が選択されているかを判断する
			if (radioButton_red.Checked) {
				color = 0;
			}else if (radioButton_blue.Checked) {
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
			}catch(FormatException exception) {
				System.Console.WriteLine("不正な数値です");
			}

			command.createCmd(width, height, x, y, color);
			List<Rectangle> onBoardRects = command.GetBoard.OnBoardRects;

			Bitmap bmp = canvas.Image as Bitmap;
			if(bmp != null) {
				bmp.Dispose();
			}

			bmp = new Bitmap(canvas.Width, canvas.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			canvas.Image = bmp;

			using(var g = Graphics.FromImage(bmp)) {
				g.Clear(Color.White);
				foreach(RectangleEditor_WinForms.Rectangle r in onBoardRects) {
					switch (r.Color) {
						case 0:
							g.FillRectangle(Brushes.Red, r.X, r.Y, r.Width, r.Height);
							break;
						case 1:
							g.FillRectangle(Brushes.Blue, r.X, r.Y, r.Width, r.Height);
							break;
						case 2:
							g.FillRectangle(Brushes.Yellow, r.X, r.Y, r.Width, r.Height);
							break;
						case 3:
							g.FillRectangle(Brushes.Gray, r.X, r.Y, r.Width, r.Height);
							break;
					}
				}
				canvas.Refresh();
			}
		}

		private void moveButton_Click(object sender, EventArgs e) {

		}

		private void canvas_Click(object sender, EventArgs e) {
			List<Rectangle> onBoardRects = command.GetBoard.OnBoardRects;

			if(onBoardRects.Count() == 0) {
				return;
			}


			
		}
	}
}
