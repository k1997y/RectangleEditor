#pragma once
#include<iostream>

class Rectangle {
	//TODO: width, height‚ªBoard‚Å‚Ílength, width‚È‚Ì‚Å“ˆê
public:
	Rectangle();
	Rectangle(int length,int width,  int x, int y, int color);
	Rectangle(int length, int width, int x, int y);

	//’·•ûŒ`‚Ì‘®«‚Ì•\¦
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