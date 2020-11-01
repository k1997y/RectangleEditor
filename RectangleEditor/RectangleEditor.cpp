#include "Command.h"
#include <iostream>

int main(int argc, char **argv) {
	Command command;
	int cmdNum=0;	//入力されたコマンド値を格納する変数

	while (command.getIsExit()) {
		std::cout << "コマンドを入力\n";
		std::cout << "1: create\n2: delete\n→";
		std::cin >> cmdNum;

		switch (cmdNum) {
		CREATE:
			command.createCmd();
		DELETE:
			command.deleteCmd();
		}
	}
	return 0;
}