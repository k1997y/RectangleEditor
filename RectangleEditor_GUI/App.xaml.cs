using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RectangleEditor_GUI {
	using System.Windows;
	using RectangleEditor_GUI.ViewModels;
	using RectangleEditor_GUI.Views;

	public partial class App : Application {
		protected override void OnStartup(StartupEventArgs e) {
			base.OnStartup(e);

			//ウィンドウのインスタンス生成
			var window = new MainView();
			
			//ウィンドウに対するViewModelのインスタンス生成
			var vm = new MainViewModel();

			//ウィンドウに対するViewModelをデータコンテキストに指定
			window.DataContext = vm;

			//ウィンドウの表示
			window.Show();
		}
	}
}
