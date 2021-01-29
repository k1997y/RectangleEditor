using System;

namespace RectangleEditor_CSharp{
    class RectangleEditor{
        static void Main(String[] args){
            Command cmd = new Command();
            int cmdNum = 0;     //入力されたコマンド値を格納する変数

			while (!cmd.isExit) {
                Console.Write("コマンドを入力\n");

				//コマンドの説明
				cmd.createDescription();
				cmd.moveDescription();
				cmd.expand_shrinkDescription();
				cmd.intersectDescription();
				cmd.deleteDescription();
				cmd.deleteAllDescription();
				cmd.displayBoardDescription();
				cmd.exitDescription();

				Console.Write("-->");
				cmdNum = int.Parse(Console.ReadLine());

				switch (cmdNum) {
					case (int)Command.Commands.CREATE:
						cmd.createCmd();
						break;
					case (int)Command.Commands.MOVE:
						cmd.moveCmd();
						break;
					case (int)Command.Commands.EXPAND_SHRINK:
						cmd.expand_shrinkCmd();
						break;
					case (int)Command.Commands.INTERSECT:
						cmd.intersectCmd();
						break;
					case (int)Command.Commands.DELETE:
						cmd.deleteCmd();
						break;
					case (int)Command.Commands.DELETEALL:
						cmd.deleteAllCmd();
						break;
					case (int)Command.Commands.DISPLAY:
						cmd.displayBoardCmd();
						break;
					case (int)Command.Commands.EXIT:
						cmd.isExit = true;
						break;
					default:
						Console.WriteLine("コマンドが不正です．もう一度入力してください.\n");
						break;
				}
			}
        }
    }
}
