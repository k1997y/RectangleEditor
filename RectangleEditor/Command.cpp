#include "Command.h"
#include <iostream>

using namespace std;

Command::Command() :
	isExit(false)
{}

void Command::createCmd() {
	int l, w, x, y, color;

	//TODO: 入力エラー処理
	cout << "縦幅を入力\n→";
	l=inputInt();
	cout << "横幅を入力\n→";
	w=inputInt();
	cout << "左上のx座標を入力\n→";
	cin >> x;
	cout << "左上のy座標を入力\n→";
	cin >> y;
	cout << "長方形の色を指定\n1: red\n2: blue\n3: yellow\n4: gray\n対応する色の番号を入力\n→";
	cin >> color;

	Rectangle *r = new Rectangle(l, w, x, y,color);

	if (board.isDuplicating(*r)) {
		std::cout << "Rectangle is duplicated " << std::endl;
	} else if (board.countRects() >= 10) {
		std::cout<<"You cannot add more.Board cannot accept > 10 rectangles "<< std::endl;
	} else {
		board.addRect(*r);
		std::cout << "Rectangle has been added " << std::endl;
		displayBoardCmd();
	}
}

void Command::moveCmd() {
	int i;
	std::cout << "designate the rectangle you move\n-->";
	std::cin >> i;

	Rectangle r = board.getRect(i-1);

	int x, y;
	std::cout << "input distance to x direction\n-->";
	std::cin >> x;
	std::cout << "input distance to x direction\n-->";
	std::cin >> y;

	int *attribute = new int[5];

	attribute = r.getAttribute();
	attribute[2] = attribute[2] + x;
	attribute[3] = attribute[3] + y;

	r.setAttribute(attribute);	

	board.replaceRect(r, i);
	std::cout << "Rectangle " << i << " has moved\n";
	displayBoardCmd();
}

void Command::intersectCmd() {

}

void Command::deleteCmd() {
	int n;
	if (board.countRects() == 0) {
		std::cout << "There are no rectangles on board" << std::endl;
		return;
	}

	displayBoardCmd();
	std::cout << "designate the rectangle you delete";
	std::cin >> n;

	board.deleteRect(n);
	std::cout << "Rectangle you designated has deleted" << std::endl;
	displayBoardCmd();
}

void Command::displayBoardCmd() {
	if (board.countRects() == 0) {
		std::cout << "There are no rectangles on board" << std::endl;
	} else {
		for (int i = 0; i < board.countRects(); i++) {
			Rectangle r = board.getRect(i);
			std::cout << i + 1 << ": ";
			r.showRectAttribute();
		}
		std::cout << std::endl;
	}
}

void Command::exitMsg() {
	isExit = true;
}

/************************
* コマンドの説明を出力する関数群
************************/
void Command::createDescription(){
	cout << CREATE+": create...Generate new rectangle";
	cout << endl;
}
void Command::moveDescription() {
	cout << MOVE+": move...Move the designated rectangle";
	cout << endl;
}
void Command::intersectDescription() {
	cout << INTERSECT + ": intersect...Extract new rectangle from range between two rectangle overlapped";
	cout << endl;
}
void Command:: deleteDescription() {
	cout << DELETE + ": delete...Delete the designated rectangle";
	cout << endl;
}
void Command::displayBoardDescription() {
	cout << DISPLAY + ": displayBoard...Display all rectangles on board";
	cout << endl;
}
void Command::exitDescription() {
	cout << EXIT + ": exit...terminate this program";
	cout << endl;
}

//TODO: 13fのように先に数値が来るとエラーがキャッチされないのでその対処
int Command::inputInt() {
	std::cin.exceptions(std::ios::failbit);		//cinの例外処理を有効にする
	int in;
	while (true) {
		try {
			cin >> in;
		}
		//...は全ての例外を受け取る構文
		catch (...) {
			cout << "不正な入力です．整数値を入力してください\n→";
			cin.clear();	//cinの中身を消去
			cin.seekg(0);		
			continue;
		}
		break;
	}
	return in;
}