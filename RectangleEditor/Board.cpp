#include "Board.h"

Board::Board() {
}

Board::~Board() {
	onBoardRect.~list();		//���X�g�̑S�Ă̗v�f��delete
}