#pragma once
#include<iostream>

class Rectangle {
public:
	Rectangle();
	Rectangle(int length,int width,  int x, int y, int color);
	Rectangle(int length, int width, int x, int y);

	//�����`�̑����̕\��
	void showRectAttribute();
	bool isSegment();
	bool isPoint();
	bool isNegative();
private:
	int length;
	int width;
	int x;
	int y;
	int color;
};