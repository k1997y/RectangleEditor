#pragma once
#include "Rectangle.h"
#include<list>

class Board {
public:
	Board();
	~Board();

	//std::list<Rectangle> getRectList() { return onBoardRect; }
	//’·•ûŒ`‚ğƒŠƒXƒg‚Å‚Â
	std::list<Rectangle> onBoardRect;
private:
	//TODO: width, height, or length, width‚Ç‚¿‚ç‚©‚É“ˆê
	const int LENGTH = 500;	//c
	const int WIDTH = 400;		//‰¡
	
};