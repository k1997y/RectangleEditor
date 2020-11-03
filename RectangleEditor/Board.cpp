#include "Board.h"

Board::Board() {
}

Board::~Board() {
	onBoardRect.~list();		//リストの全ての要素をdelete
}