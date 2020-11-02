#pragma once
#include "Board.h"

class Command {
public:
	Command();

	enum command {
		CREATE = 1,
		DELETE = 2,
		EXIT = 3
	};

	void createCmd();
	void deleteCmd();
	//exitフラグを立てる
	void exitMsg();

	bool getIsExit() { return isExit; }
private:
	Board board;
	//ループを出るか出ないかのフラグ
	bool isExit;

};