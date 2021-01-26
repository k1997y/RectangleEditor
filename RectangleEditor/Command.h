#pragma once
#include "Board.h"

class Command {
public:
	Command();

	enum command {
		CREATE = 1,
		INTERSECT=2,
		DELETE = 3,
		DISPLAY = 4,
		EXIT = 5
	};

	void createCmd();
	void intersectCmd();
	void deleteCmd();
	void displayBoardCmd();

	//exitフラグを立てる
	void exitMsg();

	bool getIsExit() { return isExit; }
private:
	Board board;

	//ループを出るか出ないかのフラグ
	bool isExit;

	//入力処理（エラー処理も行う）
	int inputInt();
};