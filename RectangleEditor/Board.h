#pragma once
#include "Rectangle.h"
#include<list>

class Board {
public:
	Board();
	~Board();

	std::list<Rectangle> getRectList() { return onBoardRect; }
private:
	//TODO: width, height, or length, width�ǂ��炩�ɓ���
	const int LENGTH = 500;	//�c
	const int WIDTH = 400;		//��

	//�����`�����X�g�Ŏ���
	std::list<Rectangle> onBoardRect;
};