#pragma once
#include "Board.h"
#include <iostream>

class Command {
public:
	Command();

	enum command {
		CREATE = 1,
		DELETE = 2,
		DISPLAY = 3,
		EXIT = 4
	};

	void createCmd();
	void deleteCmd();
	void displayBoardCmd();

	//exitフラグを立てる
	void exitMsg();

	bool getIsExit() { return isExit; }
private:
	Board board;
	//ループを出るか出ないかのフラグ
	bool isExit;

};