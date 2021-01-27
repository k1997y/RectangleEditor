#include "Board.h"

Board::Board() {
}

Board::~Board() {
	onBoardRects.~vector();		//���X�g�̑S�Ă̗v�f��delete
}

void Board::addRect(Rectangle r) {
	onBoardRects.push_back(r);
}

//index�̏ꏊ�ɑ��݂��钷���`��r�Œu������
void Board::replaceRect(Rectangle r, int index) {
	onBoardRects[index - 1] = r;
}

int Board::countRects() {
	return onBoardRects.size();
}

Rectangle Board::getRect(int i) {
	return onBoardRects[i - 1];
}

void Board::deleteRect(int i) {
	onBoardRects.erase(onBoardRects.begin()+i);
}

bool Board::isDuplicating(Rectangle r) {
	for (auto &e : onBoardRects) {
		if (e == r) {
			return true;
		}
	}
	return false;
}