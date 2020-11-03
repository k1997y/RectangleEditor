#pragma once
#include<iostream>

class Rectangle {
public:
	Rectangle();
	Rectangle(int length, int width, int x, int y, int color);
	Rectangle(int length, int width, int x, int y);

	//�����`�̑����̕\��
	void showRectAttribute();
	bool isSegment();
	bool isPoint();
	bool isNegative();

	//Rectangle�I�u�W�F�N�g���m��==�̋������`
	bool operator==(Rectangle r);
private:
	int length;
	int width;
	int x;
	int y;
	int color;
};