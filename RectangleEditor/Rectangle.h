#pragma once
#include<iostream>

class Rectangle {
public:
	//TODO: 点，線分，無は長方形とはみなさない
	Rectangle(int height, int width, int x, int y, int color);

	//長方形の属性の表示
	void showRectAttribute();
	//長方形の属性を配列で返す
	int* getAttribute();
	//長方形の属性を上書きする．
	void setAttribute(int *);
	bool isSegment();
	bool isPoint();
	bool isNegative();

	//Rectangleオブジェクト同士の==の挙動を定義
	bool operator==(Rectangle r);
private:
	int height;
	int width;
	int x;
	int y;
	int color;
};