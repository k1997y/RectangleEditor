#pragma once
#include "Rectangle.h"
#include<vector>

class Board {
public:
	Board();
	~Board();

	//�����`��ǉ�
	void addRect(Rectangle r);
	//�����`��u��
	void replaceRect(Rectangle r,int index);
	//�����`�̌���Ԃ�
	int countRects();
	//�w�肵�������`��Ԃ�
	Rectangle getRect(int);
	//�w�肵�������`�̍폜
	void deleteRect(int);
	//�����`�̏d���`�F�b�N
	bool isDuplicating(Rectangle r);
private:
	const int LENGTH = 500;	//�c
	const int WIDTH = 400;		//��

	//�����`�����X�g�Ŏ���
	std::vector<Rectangle> onBoardRects;
};