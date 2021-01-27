#pragma once
#include "Rectangle.h"
#include<vector>

class Board {
public:
	Board();
	~Board();

	//�����`��ǉ�
	void addRect(Rectangle r);
	//�����`�̌���Ԃ�
	int countRects
	//�����`�̏d���`�F�b�N
	bool isDuplicating(Rectangle r);
private:
	const int LENGTH = 500;	//�c
	const int WIDTH = 400;		//��

	//�����`�����X�g�Ŏ���
	std::vector<Rectangle> onBoardRects;
};