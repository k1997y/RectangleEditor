#include "Board.h"

Board::Board() {
	onBoardRect.resize(10);		//�v�f����10�ɐݒ�
}

Board::~Board() {
	onBoardRect.~list();		//���X�g�̑S�Ă̗v�f��delete
}