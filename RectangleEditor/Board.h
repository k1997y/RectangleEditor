#pragma once
#include "Rectangle.h"
#include<vector>

class Board {
public:
	Board();
	~Board();

	//長方形を追加
	void addRect(Rectangle r);
	//長方形を置換
	void replaceRect(Rectangle r,int index);
	//長方形の個数を返す
	int countRects();
	//指定した長方形を返す
	Rectangle getRect(int);
	//指定した長方形の削除
	void deleteRect(int);
	//長方形の重複チェック
	bool isDuplicating(Rectangle r);
private:
	const int LENGTH = 500;	//縦
	const int WIDTH = 400;		//横

	//長方形をリストで持つ
	std::vector<Rectangle> onBoardRects;
};