#include "Command.h"
#include <iostream>

int main(int argc, char **argv) {
	Command command;
	int cmdNum=0;	//���͂��ꂽ�R�}���h�l���i�[����ϐ�

	while (command.getIsExit()) {
		std::cout << "�R�}���h�����\n";
		std::cout << "1: create\n2: delete\n��";
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