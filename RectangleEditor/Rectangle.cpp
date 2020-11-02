#include"Rectangle.h"
Rectangle::Rectangle(int width, int height, int x, int y, int color) {
	this->width = width;
	this->height = height;
	this->x = x;
	this->y = y;
	this->color = color;
}
bool Rectangle::isSegment() {
	return this->width == 0 && this->height > 0 || this->width > 0 && this->height == 0;
}
bool Rectangle::isPoint() {
	return this->width == 0 && this->height == 0;
}
bool Rectangle::isNegative() {
	return this->width < 0 || this->height < 0 || this->x < 0 || this->y < 0;
}