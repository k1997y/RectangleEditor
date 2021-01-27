#pragma once
#include "Board.h"
#include <iostream>

class Command {
public:
	Command();

	enum command {
		CREATE = 1,
		MOVE =2,
		DELETE = 3,
		DISPLAY = 4,
		EXIT = 5
	};

	void createCmd();
	void moveCmd();
	void deleteCmd();
	void displayBoardCmd();

	//exitフラグを立てる
	void exitMsg();
	//入力処理（エラー処理も行う）
	int inputInt();

	bool getIsExit() { return isExit; }
private:
	Board board;
	//ループを出るか出ないかのフラグ
	bool isExit;

};