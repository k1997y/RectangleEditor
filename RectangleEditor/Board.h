#pragma once
#include "Rectangle.h"
#include<vector>

class Board {
public:
	Board();
	~Board();

	//�����`�����X�g�Ŏ���
	std::vector<Rectangle> onBoardRect;

	//�����`�̏d���`�F�b�N
	bool isDuplicating(Rectangle r);
private:
	const int LENGTH = 500;	//�c
	const int WIDTH = 400;		//��
};