#include"Rectangle.h"
#include<iostream>

Rectangle::Rectangle(int width, int height, int x, int y, int color) {
	this->width = width;
	this->height = height;
	this->x = x;
	this->y = y;
	this->color = color;
}

void Rectangle::showRectAttribute() {
	std::cout << "横幅：" << width << ", 縦幅：" << height << ", x座標：" << x << ", y座標：" << y  << ", 色： " << color<<std::endl;
}

int* Rectangle::getAttribute() {
	int *attribute = new int[5];

	attribute[0] = this->width;
	attribute[1] = this->height;
	attribute[2] = this->x;
	attribute[3] = this->y;
	attribute[4] = this->color;

	return attribute;
}

void Rectangle::setAttribute(int *attribute) {
	this->width = attribute[0];
	this->height = attribute[1];
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
	if (this->width == r.width && \
		this->height == r.height && \
		this->x == r.x && \
		this->y == r.y) {
		return true;
	} else {
		return false;
	}
}