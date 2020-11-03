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
	board.getRectList().push_back(*r);
}

void Command::deleteCmd() {
	//TODO: 入力エラー処理
	int n;
	std::cout << "ボードから削除したい長方形を選択\n→";
	std::cin >> n;

	//削除したい長方形にアクセスして削除
	//TODO: itrが正しい削除番号に到達しているかどうかの確認必要
	auto itr = board.getRectList().begin();
	for (int i = 0; i < n;i++) {
		++itr;
	}
	board.getRectList().erase(itr);
}

void Command::displayBoardCmd() {
	for (auto &r : board.getRectList()) {
		r.showRectAttribute();
	}
}

void Command::exitMsg() {
	isExit = true;
}