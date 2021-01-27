#include "Command.h"

Command::Command() :
	isExit(false)
{
}

void Command::createCmd() {
	int l, w, x, y, color;

	//TODO: 入力エラー処理
	std::cout << "縦幅を入力\n→";
	std::cin >> l;
	std::cout << "横幅を入力\n→";
	std::cin >> w;
	std::cout << "左上のx座標を入力\n→";
	std::cin >> x;
	std::cout << "左上のy座標を入力\n→";
	std::cin >> y;
	std::cout << "色を入力\n(1: red, 2: blue, 3: yellow, 4: gray)\n-->";
	std::cin >> color;

	Rectangle *r = new Rectangle(l, w, x, y,color);

	//重複がなく，個数が10個未満であればpush
	if (board.isDuplicating(*r)) {
		std::cout << "既に同じ長方形が存在しています\n" << std::endl;
	} else if (board.countRects() >= 10) {
		std::cout << "ボード上の長方形が最大個数を超えています" << std::endl;
	} else {
		board.addRect(*r);
		std::cout << "指定された値の長方形を作成しました" << std::endl;
		displayBoardCmd();
	}
}

//選択した長方形を指定分だけ移動
void Command::moveCmd() {
	int i;
	std::cout << "長方形を選択\n-->";
	std::cin >> i;

	Rectangle r = board.getRect(i-1);

	int x, y;
	std::cout << "x方向の移動距離\n-->";
	std::cin >> x;
	std::cout << "y方向の移動距離\n-->";
	std::cin >> y;

	int *attribute = new int[5];

	attribute = r.getAttribute();
	attribute[2] = attribute[2] + x;
	attribute[3] = attribute[3] + y;

	r.setAttribute(attribute);	

	board.replaceRect(r, i);
	std::cout << "長方形" << i << "を指定距離分移動しました\n";
	displayBoardCmd();
}

void Command::deleteCmd() {
	//TODO: 入力エラー処理
	int n;
	if (board.countRects() == 0) {
		std::cout << "ボード上に長方形がありません" << std::endl;
		return;
	}

	displayBoardCmd();
	std::cout << "ボードから削除したい長方形を選択\n→";
	std::cin >> n;

	board.deleteRect(n);
	std::cout << "長方形" << n << "を削除しました" << std::endl;
	displayBoardCmd();
}

void Command::displayBoardCmd() {
	if (board.countRects() == 0) {
		std::cout << "ボード上に長方形がありません" << std::endl;
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