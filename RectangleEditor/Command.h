#pragma once
#include "Board.h"

class Command {
public:
	Command();

	enum command {
		CREATE = 1,
		MOVE =2,
		EXPAND_SHRINK=3,
		INTERSECT =4,
		DELETE = 5,
		DELETEALL = 6,
		DISPLAY = 7,
		EXIT = 8
	};

	void createCmd();
	void moveCmd();
	void expand_shrinkCmd();
	void intersectCmd();
	void deleteCmd();
	void deleteAllCmd();
	void displayBoardCmd();

	//exitフラグを立てる
	void exitMsg();

	//以下コマンドの説明を出力する関数
	void createDescription();
	void moveDescription();
	void expand_shrinkDescription();
	void intersectDescription();
	void deleteDescription();
	void deleteAllDescription();
	void displayBoardDescription();
	void exitDescription();

	bool getIsExit() { return isExit; }
private:
	Board board;

	//ループを出るか出ないかのフラグ
	bool isExit;

	//入力処理（エラー処理も行う）
	int inputInt();
};