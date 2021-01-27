#include"Rectangle.h"

Rectangle::Rectangle() {}

Rectangle::Rectangle(int height, int width, int x, int y, int color) {
	this->height = height;
	this->width = width;
	this->x = x;
	this->y = y;
	this->color = color;
}

Rectangle::Rectangle(int height, int width, int x, int y) :
	height(height),
	width(width),
	x(x),
	y(y)
{
}

void Rectangle::showRectAttribute() {
	std::cout << "縦幅：" << height << ", 横幅：" << width << ", x座標：" << x << ", y座標：" << y  << std::endl;
}

int* Rectangle::getAttribute() {
	int attribute[5];
	attribute[0] = this->height;
	attribute[1] = this->width;
	attribute[2] = this->x;
	attribute[3] = this->y;
	attribute[4] = this->color;
}

void Rectangle::setAttribute(int *attribute) {
	this->height = attribute[0];
	this->width = attribute[1];
	this->x = attribute[2];
	this->y = attribute[3];
	this->color = attribute[4];
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

bool Rectangle::operator== (Rectangle r) {
	if (this->height == r.height && \
		this->width == r.width && \
		this->x == r.x && \
		this->y == r.y) {
		return true;
	} else {
		return false;
	}
}