#include "Board.h"

Board::Board() {
}

Board::~Board() {
	onBoardRects.~vector();		//リストの全ての要素をdelete
}

void Board::addRect(Rectangle r) {
	onBoardRects.push_back(r);
}

int Board::countRects() {
	return onBoardRects.size();
}

Rectangle Board::getRect(int i) {
	return onBoardRects[i - 1];
}

bool Board::isDuplicating(Rectangle r) {
	for (auto &e : onBoardRects) {
		if (e == r) {
			return true;
		}
	}
	return false;
}