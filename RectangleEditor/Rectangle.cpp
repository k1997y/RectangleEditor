#include"Rectangle.h"

Rectangle::Rectangle() {}

Rectangle::Rectangle(int length, int width, int x, int y, int color) {
	this->length = length;
	this->width = width;
	this->x = x;
	this->y = y;
	this->color = color;
}

Rectangle::Rectangle(int length, int width, int x, int y) :
	length(length),
	width(width),
	x(x),
	y(y)
{
}

void Rectangle::showRectAttribute() {
	std::cout << "�c���F" << length << ", �����F" << width << ", x���W�F" << x << ", y���W�F" << y  << std::endl;
}

int* Rectangle::getAttribute() {
	int attribute[5];
	attribute[0] = this->length;
	attribute[1] = this->width;
	attribute[2] = this->x;
	attribute[3] = this->y;
	attribute[4] = this->color;
}

bool Rectangle::isSegment() {
	return this->width == 0 && this->length > 0 || this->width > 0 && this->length == 0;
}

bool Rectangle::isPoint() {
	return this->width == 0 && this->length == 0;
}

bool Rectangle::isNegative() {
	return this->width < 0 || this->length < 0 || this->x < 0 || this->y < 0;
}

bool Rectangle::operator== (Rectangle r) {
	if (this->length == r.length && \
		this->width == r.width && \
		this->x == r.x && \
		this->y == r.y) {
		return true;
	} else {
		return false;
	}
}