#pragma once
#include<iostream>

class Rectangle {
public:
	//TODO: 点，線分，無は長方形とはみなさない
	Rectangle();
	Rectangle(int length, int width, int x, int y, int color);
	Rectangle(int length, int width, int x, int y);

	//長方形の属性の表示
	void showRectAttribute();
	bool isSegment();
	bool isPoint();
	bool isNegative();

	//Rectangleオブジェクト同士の==の挙動を定義
	bool operator==(Rectangle r);
private:
	int length;
	int width;
	int x;
	int y;
	int color;
};