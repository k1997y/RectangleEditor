#include"Rectangle.h"

Rectangle::Rectangle(){}

Rectangle::Rectangle(int length, int width,  int x, int y, int color) {
	this->length = length;
	this->width = width;
	this->x = x;
	this->y = y;
	this->color = color;
}

Rectangle::Rectangle(int length, int width, int x, int y):
	length(length),
	width(width),
	x(x),
	y(y)
{
}

void Rectangle::showRectAttribute() {
	std::cout << "縦幅：" << length << ", 横幅：" << width << ", x座標：" << x << ", y座標：" << y << std::endl << std::endl;
}

bool Rectangle::isSegment() {
	return this->width == 0 && this->length > 0 || this->width > 0 && this->length == 0;
}
bool Rectangle::isPoint() {
	return this->width == 0 && this->length == 0;
}
bool Rectangle::isNegative() {
	return this->width < 0 || this->length< 0 || this->x < 0 || this->y < 0;
}