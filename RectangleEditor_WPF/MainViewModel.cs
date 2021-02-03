using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RectangleEditor_WPF {
	abstract class ViewModelBase : INotifyPropertyChanged {
		//プロパティの変更通知
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string name) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
	}

	class MainViewModel : ViewModelBase{

	}
}
