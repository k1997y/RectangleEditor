#include "Board.h"

Board::Board() {
}

Board::~Board() {
	onBoardRect.~vector();		//リストの全ての要素をdelete
}

bool Board::isDuplicating(Rectangle r) {
	for (auto &e : onBoardRect) {
		if (e == r) {
			return true;
		}
	}
	return false;
}