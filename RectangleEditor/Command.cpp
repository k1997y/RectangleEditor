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
	//rがボードに配置できる長方形であるかをチェック

	board.onBoardRect.push_back(*r);
}

void Command::deleteCmd() {
	//TODO: 入力エラー処理
	int n;
	displayBoardCmd();
	std::cout << "ボードから削除したい長方形を選択\n→";
	std::cin >> n;

	//削除したい長方形にアクセスして削除
	auto itr = board.onBoardRect.begin();
	for (int i = 0; i < n;i++) {
		++itr;
	}
	board.onBoardRect.erase(itr);
}

void Command::displayBoardCmd() {
	int i = 0;
	for (auto &r : board.onBoardRect) {
		std::cout << i + 1 << ": ";
		r.showRectAttribute();
		i++;
	}
}

void Command::exitMsg() {
	isExit = true;
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