#include "Board.h"

Board::Board() {
}

Board::~Board() {
	onBoardRect.~list();		//���X�g�̑S�Ă̗v�f��delete
}

bool Board::isDuplicating(Rectangle r) {
	for (auto &e : onBoardRect) {
		if (e == r) {
			return true;
		}
	}
	return false;
}