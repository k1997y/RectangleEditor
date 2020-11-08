#include"Rectangle.h"
#include<iostream>

//Rectangle::Rectangle(int length, int width,  int x, int y, Color color) {
//	this->length = length;
//	this->width = width;
//	this->x = x;
//	this->y = y;
//	this->color = color;
//}

Rectangle::Rectangle(int length, int width, int x, int y, int color) :
	length(length),
	width(width),
	x(x),
	y(y),
	color(color)
{
}

void Rectangle::showRectAttribute() {
	std::cout << "縦幅：" << length << ", 横幅：" << width << ", 左上x座標：" << x << ", 左上y座標：" << y <<", 色："<<color<<std::endl << std::endl;
}

bool Rectangle::isSegment() {
	return width == 0 && length > 0 || width > 0 && length == 0;
}
bool Rectangle::isPoint() {
	return this->width == 0 && this->length == 0;
}
bool Rectangle::isNegative() {
	return this->width < 0 || this->length< 0 || this->x < 0 || this->y < 0;
}