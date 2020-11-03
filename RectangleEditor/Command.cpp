#include "Command.h"

Command::Command() :
	isExit(false)
{
}

void Command::createCmd() {
	int l, w, x, y;

	//TODO: 入力エラー処理
	std::cout << "縦幅を入力\n→";
	std::cin >> l;
	std::cout << "横幅を入力\n→";
	std::cin >> w;
	std::cout << "左上のx座標を入力\n→";
	std::cin >> x;
	std::cout << "左上のy座標を入力\n→";
	std::cin >> y;

	Rectangle *r = new Rectangle(l, w, x, y);
	//board.getRectList().push_back(*r);
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