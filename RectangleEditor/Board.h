#pragma once
#include "Rectangle.h"
#include<vector>

class Board {
public:
	Board();
	~Board();

	//長方形の重複チェック
	bool isDuplicating(Rectangle r);
private:
	const int LENGTH = 500;	//縦
	const int WIDTH = 400;		//横

	//長方形をリストで持つ
	std::vector<Rectangle> onBoardRect;
};