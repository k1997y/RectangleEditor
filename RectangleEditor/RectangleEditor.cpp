#include "Command.h"
#include <iostream>

int input();

int main(int argc, char **argv) {
	Command cmd;
	int cmdNum = 0;	//���͂��ꂽ�R�}���h�l���i�[����ϐ�

	while (!cmd.getIsExit()) {
		std::cout<< "�R�}���h�����\n";
		
		//�R�}���h�̐���
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
				std::cout << "�R�}���h���s���ł��D������x���͂��Ă��������D" << std::endl;
				break;
		}
	}
	return 0;
}