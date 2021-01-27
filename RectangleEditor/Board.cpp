#include "Board.h"

Board::Board() {
}

Board::~Board() {
	onBoardRect.~vector();		//リストの全ての要素をdelete
}

void Board::addRect(Rectangle r) {
	onBoardRect.push_back(r);
}

bool Board::isDuplicating(Rectangle r) {
	for (auto &e : onBoardRect) {
		if (e == r) {
			return true;
		}
	}
	return false;
}