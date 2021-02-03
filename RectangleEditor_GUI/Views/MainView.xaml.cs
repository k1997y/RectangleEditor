using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RectangleEditor_GUI.Models;

namespace RectangleEditor_GUI.Views {
	/// <summary>
	/// MainView.xaml の相互作用ロジック
	/// </summary>
	public partial class MainView : Window {
		public Command Command { get; }


		public MainView() {
			InitializeComponent();
			this.Command = new Command();
		}


		public static int color;
		private void ColorChecked(object sender, RoutedEventArgs e) {
			var radioButton = (RadioButton)sender;

			string colorString = radioButton.Content.ToString();
			if(colorString == "red") {
				color = 0;
			}else if (colorString == "blue") {
				color = 1;
			}else if(colorString == "yellow") {
				color = 2;
			}else if(colorString == "green") {
				color = 3;
			}
		}

		private void CreateClicked(object sender, RoutedEventArgs e) {

		}
	}
}
