﻿#pragma once
#include<iostream>

class Rectangle {
public:
	//TODO: 点，線分，無は長方形とはみなさない
	Rectangle(int height, int width, int x, int y, int color);

	void showRectAttribute();
	int *getAttribute();
	void setAttribute(int *);
	bool isSegment();
	bool isPoint();
	bool isNegative();
	
	//defined comparison operator
	bool operator==(Rectangle r);
private:
	/*enum Color {
		RED,
		BLUE,
		YELLOW,
		GRAY,
		GREEN,
		ORANGE,
		MAGENTA,
		CYAN,
		WHITE
	};*/

	int height;
	int width;
	int x;
	int y;
	int color;
};