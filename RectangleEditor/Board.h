#pragma once
#include "Rectangle.h"
#include<list>

class Board {
public:
	Board();
	~Board();

	//�����`�����X�g�Ŏ���
	std::list<Rectangle> onBoardRect;
private:
	const int LENGTH = 500;	//�c
	const int WIDTH = 400;		//��
	
	//�����`�̏d���`�F�b�N
	bool isDuplicating(Rectangle r);
};