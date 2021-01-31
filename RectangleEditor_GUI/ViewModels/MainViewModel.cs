using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_GUI.ViewModels {
	using System.ComponentModel;
	using System.Runtime.CompilerServices;

	/// <summary>
	/// MainViewウィンドウに対するデータコンテキストを表す
	/// </summary>
	internal class MainViewModel : NotificationObject {
		private string _width;
		public string Width {
			get { return this._width; }
			set {
				SetProperty(ref this._width, value);
			}
		}

		private string _height;
		public string Height {
			get { return this._height; }
			set {
				SetProperty(ref this._height, value);
			}
		}

		private string _x;
		public string X {
			get { return this._x; }
			set {
				SetProperty(ref this._x, value);
			}
		}

		private string _y;
		public string Y {
			get { return this._y; }
			set {
				SetProperty(ref this._y, value);
			}
		}



		//createコマンドを取得する
		private DelegateCommand _createCommand;
		public DelegateCommand CreateCommand {
			get {
				return this._createCommand ?? (this._createCommand = new DelegateCommand(
					_ => {
						onCreate();
					}));
			}
		}
		private void onCreate() {
			throw new NotImplementedException();
		}
	}
}