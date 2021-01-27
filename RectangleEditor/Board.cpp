#include "Board.h"

Board::Board() {
}

Board::~Board() {
	onBoardRects.~vector();		//���X�g�̑S�Ă̗v�f��delete
}

void Board::addRect(Rectangle r) {
	onBoardRects.push_back(r);
}

int Board::countRects() {
	return onBoardRects.size();
}

bool Board::isDuplicating(Rectangle r) {
	for (auto &e : onBoardRects) {
		if (e == r) {
			return true;
		}
	}
	return false;
}