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
		private string _upperString;
		/// <summary>
		/// 全て大文字に変換した文字列を取得する
		/// </summary>
		public string UpperString {
			get { return this._upperString; }
			private set { SetProperty(ref this._upperString, value); }
		}

		private string _inputString;
		/// <summary>
		/// 入力文字列を取得または設定する
		/// </summary>
		public string InputString {
			get { return this._inputString; }
			set {
				if (SetProperty(ref this._inputString, value)) {
					//入力文字列を大文字に変換
					this.UpperString = this._inputString.ToUpper();

					//出力ウィンドウに結果表示
					System.Diagnostics.Debug.WriteLine(this._inputString);
				}
			}
		}
	}
}