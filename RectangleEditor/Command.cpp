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

	//重複がなく，個数が10個未満であればpush
	if (board.isDuplicating(*r)) {
		std::cout << "既に同じ長方形が存在しています\n" << std::endl;
	} else if (board.onBoardRect.size()>=10) {
		std::cout << "ボード上の長方形が最大個数を超えています" << std::endl;
	}else {
		board.onBoardRect.push_back(*r);
		std::cout << "指定された値の長方形を作成しました" << std::endl;
		displayBoardCmd();
	}
}

//選択した長方形を指定分だけ移動
void Command::moveCmd() {
	int i;
	std::cout << "長方形を選択\n-->";
	std::cin >> i;

	
	/*アルゴリズム
	* １．長方形Rを指定させる
	* ２．指定した番号の長方形を呼び出す
	* （C++のListは直接呼び出す関数がない．以下呼び出し方法）
	* auto itr = board.onBoardRect.begin();
	   for (int i = 0; i < n-1;i++) {
	   ++itr;
	}
	Rectangle r = *itr;
	*itrは要素を指すポインタらしい．とにかくこうすればn番目の要素にアクセスできるかと思う
	* ３．呼び出した長方形のx, y座標を書き換える
	*/
}

void Command::deleteCmd() {
	//TODO: 入力エラー処理
	int n;
	if (board.onBoardRect.size() == 0) {
		std::cout << "ボード上に長方形がありません" << std::endl;
		return;
	}

	displayBoardCmd();
	std::cout << "ボードから削除したい長方形を選択\n→";
	std::cin >> n;

	//削除したい長方形にアクセスして削除
	auto itr = board.onBoardRect.begin();
	for (int i = 0; i < n-1;i++) {
		++itr;
	}
	board.onBoardRect.erase(itr);
	std::cout << "長方形" << n << "を削除しました" << std::endl;
	displayBoardCmd();
}

void Command::displayBoardCmd() {
	int i = 0;
	if (board.onBoardRect.size() == 0) {
		std::cout << "ボード上に長方形がありません" << std::endl;
	} else {
		for (auto &r : board.onBoardRect) {
			std::cout << i + 1 << ": ";
			r.showRectAttribute();
			i++;
		}
	}
}

void Command::exitMsg() {
	isExit = true;
}