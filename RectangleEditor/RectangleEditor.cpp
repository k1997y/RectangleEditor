#include "Command.h"
#include <iostream>

int main(int argc, char **argv) {
	Command cmd;
	int cmdNum = 0;	//入力されたコマンド値を格納する変数

	while (!cmd.getIsExit()) {
		std::cout << "コマンドを入力\n";
		std::cout << "1: create...新たな長方形を生成\n2: delete...選択した長方形を削除\n3: exit...プログラムの終了\n→";
		std::cin >> cmdNum;

		switch (cmdNum) {
			case cmd.CREATE:
				cmd.createCmd();
				break;
			case cmd.DELETE:
				cmd.deleteCmd();
				break;
			case cmd.DISPLAY:
				cmd.displayBoardCmd();
			case cmd.EXIT:
				cmd.exitMsg();
			default:
				std::cout << "コマンドが不正です．もう一度入力してください．" << std::endl;
				break;
		}
	}
	return 0;
}