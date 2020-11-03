#pragma once
#include "Rectangle.h"
#include<list>

class Board {
public:
	Board();
	~Board();

	//長方形をリストで持つ
	std::list<Rectangle> onBoardRect;
private:
	const int LENGTH = 500;	//縦
	const int WIDTH = 400;		//横
	
	//長方形の重複チェック
	bool isDuplicating(Rectangle r);
};