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

		public Form1() {
			InitializeComponent();
			command = new Command();
		}

		private void createButton_Click(object sender, EventArgs e) {
			int width, height, x, y, color;

			//どの色が選択されているかを判断する
			if (radioButton_red.Checked) {
				color = 0;
			}else if (radioButton_blue.Checked) {
				color = 1;
			} else if (radioButton_yellow.Checked) {
				color = 2;
			} else if (radioButton_grey.Checked) {
				color = 3;
			}

			width = int.Parse(textBox_width.Text);
			height = int.Parse(textBox_height.Text);
			x = int.Parse(textBox_x.Text);
			y = int.Parse(textBox_y.Text);


		}
	}
}
