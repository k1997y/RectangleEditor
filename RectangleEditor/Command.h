#pragma once
#include "Board.h"

class Command {
public:
	Command();

	enum command {
		CREATE = 1,
		MOVE =2,
		INTERSECT =3,
		DELETE = 4,
		DISPLAY = 5,
		EXIT = 6
	};

	void createCmd();
	void moveCmd();
	void intersectCmd();
	void deleteCmd();
	void displayBoardCmd();

	//exitフラグを立てる
	void exitMsg();

	//以下コマンドの説明を出力する関数
	void createDescription();
	void moveDescription();
	void intersectDescription();
	void deleteDescription();
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