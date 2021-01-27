#include "Command.h"
#include <iostream>
#include<cmath>

using namespace std;

Command::Command() :
	isExit(false)
{}

void Command::createCmd() {
	int w,h, x, y, color;

	//TODO: ���̓G���[����
	cout << "���������\n��";
	w=inputInt();
	cout << "�c�������\n��";
	h=inputInt();
	cout << "�����x���W�����\n��";
	cin >> x;
	cout << "�����y���W�����\n��";
	cin >> y;
	cout << "�����`�̐F���w��\n1: red\n2: blue\n3: yellow\n4: gray\n�Ή�����F�̔ԍ������\n��";
	cin >> color;

	Rectangle *r = new Rectangle( w,h, x, y,color);

	if (board.isDuplicating(*r)) {
		std::cout << "Rectangle is duplicated " << std::endl;
	} else if (board.countRects() >= 10) {
		std::cout<<"You cannot add more.Board cannot accept > 10 rectangles "<< std::endl;
	} else {
		board.addRect(*r);
		std::cout << "Rectangle has been added " << std::endl;
		displayBoardCmd();
	}
}

void Command::moveCmd() {
	int n;
	std::cout << "designate the rectangle you move\n-->";
	std::cin >> n;

	Rectangle r = board.getRect(n-1);

	int x, y;
	std::cout << "input distance to x direction\n-->";
	std::cin >> x;
	std::cout << "input distance to x direction\n-->";
	std::cin >> y;

	int *attribute = new int[5];

	attribute = r.getAttribute();
	attribute[2] = attribute[2] + x;
	attribute[3] = attribute[3] + y;
	r.setAttribute(attribute);	

	board.replaceRect(r, n);
	std::cout << "Rectangle " << n << " has moved\n";
	displayBoardCmd();
}

void Command::expand_shrinkCmd() {
	int n;
	std::cout << "designate the rectange you alter\n-->";
	std::cin >> n;

	Rectangle r = board.getRect(n- 1);

	//�g��k����
	double mx, my;
	std::cout << "input width scaling rate";
	std::cin >> mx;
	std::cout << "input height scaling rate";
	std::cin >> my;

	int *attribute = new int[5];

	attribute = r.getAttribute();
	attribute[0] = round(attribute[0] * mx);
	attribute[1] = round(attribute[1] * my);
	r.setAttribute(attribute);

	board.replaceRect(r, n);
	std::cout << "Rectangle " << n << " has altered\n";
	displayBoardCmd();
}

void Command::intersectCmd() {

}

void Command::deleteCmd() {
	int n;
	if (board.countRects() == 0) {
		std::cout << "There are no rectangles on board" << std::endl;
		return;
	}

	displayBoardCmd();
	std::cout << "designate the rectangle you delete";
	std::cin >> n;

	board.deleteRect(n);
	std::cout << "Rectangle you designated has deleted" << std::endl;
	displayBoardCmd();
}

void Command::displayBoardCmd() {
	if (board.countRects() == 0) {
		std::cout << "There are no rectangles on board" << std::endl;
	} else {
		for (int i = 0; i < board.countRects(); i++) {
			Rectangle r = board.getRect(i);
			std::cout << i + 1 << ": ";
			r.showRectAttribute();
		}
		std::cout << std::endl;
	}
}

void Command::exitMsg() {
	isExit = true;
}

/************************
* �R�}���h�̐������o�͂���֐��Q
************************/
void Command::createDescription(){
	cout <<CREATE<<": create...Generate new rectangle";
	cout << endl;
}
void Command::moveDescription() {
	cout << MOVE<<": move...Move the designated rectangle";
	cout << endl;
}
void Command::expand_shrinkDescription() {
	cout << EXPAND_SHRINK << ": expand/shrink...Alter size of the designated rectangle";
	cout << endl;
}
void Command::intersectDescription() {
	cout << INTERSECT << ": intersect...Extract new rectangle from range between two rectangle overlapped";
	cout << endl;
}
void Command:: deleteDescription() {
	cout << DELETE << ": delete...Delete the designated rectangle";
	cout << endl;
}
void Command::displayBoardDescription() {
	cout << DISPLAY << ": displayBoard...Display all rectangles on board";
	cout << endl;
}
void Command::exitDescription() {
	cout << EXIT << ": exit...terminate this program";
	cout << endl;
}

//TODO: 13f�̂悤�ɐ�ɐ��l������ƃG���[���L���b�`����Ȃ��̂ł��̑Ώ�
int Command::inputInt() {
	std::cin.exceptions(std::ios::failbit);		//cin�̗�O������L���ɂ���
	int in;
	while (true) {
		try {
			cin >> in;
		}
		//...�͑S�Ă̗�O���󂯎��\��
		catch (...) {
			cout << "�s���ȓ��͂ł��D�����l����͂��Ă�������\n��";
			cin.clear();	//cin�̒��g������
			cin.seekg(0);		
			continue;
		}
		break;
	}
	return in;
}