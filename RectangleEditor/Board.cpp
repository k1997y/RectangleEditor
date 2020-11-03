#include "Board.h"

Board::Board() {
	onBoardRect.resize(10);		//要素数を10に設定
}

Board::~Board() {
	onBoardRect.~list();		//リストの全ての要素をdelete
}