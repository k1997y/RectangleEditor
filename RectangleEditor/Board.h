#pragma once
#include "Rectangle.h"
#include<list>

class Board {
public:
	Board();
	~Board();

	std::list<Rectangle> getRectList() { return onBoardRect; }
private:
	//TODO: width, height, or length, widthどちらかに統一
	const int LENGTH = 500;	//縦
	const int WIDTH = 400;		//横

	//長方形をリストで持つ
	std::list<Rectangle> onBoardRect;
};