#include "Command.h"

Command::Command() :
	isExit(false)
{
}

//TODO: 長方形個数を10に制限
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
	//重複がなければpush
	if (board.isDuplicating(*r)) {
		std::cout << "既に同じ長方形が存在しています\n" << std::endl;
	} else {
		board.onBoardRect.push_back(*r);
	}
}

//TODO: ボード上に長方形が無い場合の処理
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

//TODO: ボード上の長方形が0のときの処理
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