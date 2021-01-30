using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_GUI.ViewModels {
	using System.ComponentModel;
	using System.Runtime.CompilerServices;

	internal abstract class NotificationObject : INotifyPropertyChanged{
		/// <summary>
		/// プロパティに変更があった場合に発生する
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// PropertyChangedイベントを発行する
		/// </summary>
		/// <param name="propertyName">プロパティ値に変更があったプロパティ名を指定する</param>
		protected void RaisePropertyChanged([CallerMemberName]string propertyName = null) {
			var h  =this.PropertyChanged;
			if(h != null) {
				h(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		/// <summary>
		/// プロパティ値を変更するヘルパー
		/// </summary>
		/// <typeparam name="T">プロパティの型を表す</typeparam>
		/// <param name="target">変更するプロパティの実体をref指定する</param>
		/// <param name="value">変更後の値を指定する</param>
		/// <param name="propertyName">プロパティ名を指定する</param>
		/// <returns>プロパティ値に変更があった場合にtrueを返す</returns>
		protected bool SetProperty<T>(ref T target, T value, [CallerMemberName] string propertyName = null) {
			if (Equals(target, value)) {
				return false;
			}
			target = value;
			RaisePropertyChanged(propertyName);
			return true;
		}
	}
}
