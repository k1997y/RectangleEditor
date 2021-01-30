using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleEditor_GUI.ViewModels {
	using System.Windows.Input;

	internal class DelegateCommand : ICommand{
		/// <summary>
		/// コマンド実行時の処理内容を保持する
		/// </summary>
		private Action<Object> _execute;

		/// <summary>
		/// コマンド実行可能判別の処理内容を保持する
		/// </summary>
		private Func<object, bool> _canExecute;

		/// <summary>
		/// 新しいインスタンスを生成する
		/// </summary>
		/// <param name="execute"> コマンド実行処理を指定する </param>
		public DelegateCommand(Action<object> execute)
			:this(execute,null) { }

		/// <summary> 
		/// 新しいインスタンスを生成する
		/// </summary>
		/// <param name="execute"> コマンド実行処理を指定する </param>
		/// <param name="canExecute"> コマンド実行可能判別処理を指定する</param>
		public DelegateCommand(Action<object> execute, Func<object, bool> canExecute) {
			this._execute = execute;
			this._canExecute = canExecute;
		}

		/// <summary>
		/// コマンドが実行可能かどうかの判別処理を行う
		/// </summary>
		/// <param name="parameter"> 判別処理に対するパラメータを指定する </param>
		/// <returns> 実行可能な場合にtrueを返す</returns>
		public bool CanExecute(object parameter) {
			return (this._canExecute != null) ? this._canExecute(parameter) : true;
		}

		/// <summary>
		/// 実行可能かどうかの判別処理に関する状態が変更されたときに発生する
		/// </summary>
		public event EventHandler CanExecuteChanged;

		/// <summary>
		/// CanExecuteChangedイベントを発行する
		/// </summary>
		public void RaiseCanExecuteChanged() {
			var h = this.CanExecuteChanged;
			if (h != null) h(this, EventArgs.Empty);
		}

		/// <summary>
		/// コマンドが実行されたときの処理を行う
		/// </summary>
		/// <param name="parameter">コマンドに対するぱためーたを指定する</param>
		public void Execute(object parameter) {
			if(this._execute != null) {
				this._execute(parameter);
			}
		}
	}
}
