#pragma once
#include<iostream>

class Rectangle {
public:
	//TODO: �_�C�����C���͒����`�Ƃ݂͂Ȃ��Ȃ�
	Rectangle(int height, int width, int x, int y, int color);

	//�����`�̑����̕\��
	void showRectAttribute();
	//�����`�̑�����z��ŕԂ�
	int* getAttribute();
	//�����`�̑������㏑������D
	void setAttribute(int *);
	bool isSegment();
	bool isPoint();
	bool isNegative();

	//Rectangle�I�u�W�F�N�g���m��==�̋������`
	bool operator==(Rectangle r);
private:
	int height;
	int width;
	int x;
	int y;
	int color;
};