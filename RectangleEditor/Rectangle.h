#pragma once
class Rectangle {
private:
	int width;
	int height;
	int x;
	int y;
	int color;
public:
	Rectangle(int width, int height, int x, int y, int color);
	bool isSegment();
	bool isPoint();
	bool isNegative();
};