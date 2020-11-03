#pragma once
#include "Rectangle.h"
#include<list>

class Board {
public:
	Board();
	~Board();

	//�����`�����X�g�Ŏ���
	std::list<Rectangle> onBoardRect;

	//�����`�̏d���`�F�b�N
	bool isDuplicating(Rectangle r);
private:
	const int LENGTH = 500;	//�c
	const int WIDTH = 400;		//��
	
};