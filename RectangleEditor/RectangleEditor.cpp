#include "Command.h"
#include <iostream>

int main(int argc, char **argv) {
	Command cmd;
	int cmdNum = 0;	//���͂��ꂽ�R�}���h�l���i�[����ϐ�

	while (!cmd.getIsExit()) {
		std::cout << "�R�}���h�����\n";
		std::cout << "1: create\n2: delete\n��";
		std::cin >> cmdNum;

		switch (cmdNum) {
			case cmd.CREATE:
				cmd.createCmd();
				break;
			case cmd.DELETE:
				cmd.deleteCmd();
				break;
			default:
				std::cout << "�R�}���h���s���ł��D������x���͂��Ă��������D" << std::endl;
				break;
		}
	}
	return 0;
}