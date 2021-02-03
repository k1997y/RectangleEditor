using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_GUI.ViewModels {
	using System.ComponentModel;
	using System.Runtime.CompilerServices;
	using System.Windows;
	using System.Windows.Controls;
	using System.Windows.Media;
	using RectangleEditor_GUI.Models;
	using RectangleEditor_GUI.Views;

	/// <summary>
	/// MainViewウィンドウに対するデータコンテキストを表す
	/// </summary>
	internal class MainViewModel : NotificationObject {
		/// <summary>
		///  コマンドの処理を定義するクラスのインスタンス
		/// </summary>
		public Command _command { get; }
		//public Command _command;

		public MainViewModel() {
			this._command = new Command();
		}

		private string _width;
		public string Width {
			get { return this._width; }
			set {
				if(SetProperty(ref this._width, value)) {
					this.CreateCommand.RaiseCanExecuteChanged();
				}
			}
		}

		private string _height;
		public string Height {
			get { return this._height; }
			set {
				if (SetProperty(ref this._height, value)) {
					this.CreateCommand.RaiseCanExecuteChanged();
				}
			}
		}

		private string _x;
		public string X {
			get { return this._x; }
			set {
				if (SetProperty(ref this._x, value)) {
					this.CreateCommand.RaiseCanExecuteChanged();
				}
			}
		}

		private string _y;
		public string Y {
			get { return this._y; }
			set {
				if (SetProperty(ref this._y, value)) {
					this.CreateCommand.RaiseCanExecuteChanged();
				}
			}
		}


		//private string _color;
		//public string Color {
		//	get { return this._color; }
		//	set {
		//		if (SetProperty(ref this._color, value)) {
		//			this.CreateCommand.RaiseCanExecuteChanged();
		//		}
		//	}
		//}

		//createコマンドを取得する
		private DelegateCommand _createCommand;
		public DelegateCommand CreateCommand {
			get {
				return this._createCommand ?? (this._createCommand = new DelegateCommand(
					_ => {
						onCreate();
						DrawRectangle();
					}));
			}
		}

		private void onCreate() {
			int width, height, x, y;

			if(!int.TryParse(this._width,out width)) {
				return;
			}
			if(!int.TryParse(this._height,out height)) {
				return;
			}
			if (!int.TryParse(this._x, out x)) {
				return;
			}
			if (!int.TryParse(this._y, out y)) {
				return;
			}
			//if (!int.TryParse(this._color, out color)) {
			//	return;
			//}
			this._command.createCmd(width, height, x, y, Views.MainView.color);
		}

		private void DrawRectangle() {
			Command command = _command;
			var rects = command.GetBoard.OnBoardRects;
			var canvas = (System.Windows.Controls.Canvas)sender;

			foreach (Models.Rectangle r in rects) {
				System.Windows.Shapes.Rectangle rectangle = new System.Windows.Shapes.Rectangle();

				switch (r.Color) {
					case 0:
						rectangle.Stroke = new SolidColorBrush(Colors.Red);
						break;
					case 1:
						rectangle.Stroke = new SolidColorBrush(Colors.Blue);
						break;
					case 2:
						rectangle.Stroke = new SolidColorBrush(Colors.Yellow);
						break;
					case 3:
						rectangle.Stroke = new SolidColorBrush(Colors.Green);
						break;
				}

				rectangle.StrokeThickness = 1;
				rectangle.Width = r.Width;
				rectangle.Height = r.Height;

				Canvas.SetLeft(rectangle, r.X);
				Canvas.SetTop(rectangle, r.Y);

				canvas.Children.Add(rectangle);
			}
		}
	}
}