#pragma once
#include "Rectangle.h"
#include<list>

class Board {
public:
	Board();
	~Board();

	//’·•ûŒ`‚ğƒŠƒXƒg‚Å‚Â
	std::list<Rectangle> onBoardRect;
private:
	const int LENGTH = 500;	//c
	const int WIDTH = 400;		//‰¡
	
};