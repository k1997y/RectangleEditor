#include "Command.h"
#include <iostream>

int input();

int main(int argc, char **argv) {
	Command cmd;
	int cmdNum = 0;	//入力されたコマンド値を格納する変数

	while (!cmd.getIsExit()) {
		std::cout<< "コマンドを入力\n";
		
		//コマンドの説明
		cmd.createDescription();
		cmd.moveDescription();
		cmd.expand_shrinkDescription();
		cmd.intersectDescription();
		cmd.deleteDescription();
		cmd.displayBoardDescription();
		cmd.exitDescription();

		std::cin >> cmdNum;

		switch (cmdNum) {
			case cmd.CREATE:
				cmd.createCmd();
				break;
			case cmd.MOVE:
				cmd.moveCmd();
				break;
			case cmd.EXPAND_SHRINK:
				cmd.expand_shrinkCmd();
				break;
			case cmd.INTERSECT:
				cmd.intersectCmd();
				break;
			case cmd.DELETE:
				cmd.deleteCmd();
				break;
			case cmd.DISPLAY:
				cmd.displayBoardCmd();
				break;
			case cmd.EXIT:
				cmd.exitMsg();
				break;
			default:
				std::cout << "コマンドが不正です．もう一度入力してください．" << std::endl;
				break;
		}
	}
	return 0;
}