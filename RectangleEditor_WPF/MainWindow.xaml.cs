using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RectangleEditor_WPF {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		private MainViewModel viewModel = new MainViewModel();

		public MainWindow() {
			InitializeComponent();
			DataContext = this.viewModel;
		}

		private int color;
		private void ColorChecked(object sender, RoutedEventArgs e) {
			var radioButton = (RadioButton)sender;

			string colorString = radioButton.Content.ToString();
			if (colorString == "red") {
				color = 0;
			} else if (colorString == "blue") {
				color = 1;
			} else if (colorString == "yellow") {
				color = 2;
			} else if (colorString == "green") {
				color = 3;
			}
		}

		private void CreateClicked(object sender, RoutedEventArgs e) {
			int width, height, x, y;

			if (!int.TryParse(textbox_width.Text,out width)) {
				return;
			}
			if (!int.TryParse(textbox_height.Text, out height)) {
				return;
			}
			if (!int.TryParse(textbox_x.Text, out x)) {
				return;
			}
			if (!int.TryParse(textbox_y.Text, out y)) {
				return;
			}

		}
	}
}
