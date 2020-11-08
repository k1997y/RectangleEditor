#include "Command.h"
#include <iostream>

using namespace std;

Command::Command() :
	isExit(false)
{}

void Command::createCmd() {
	int l, w, x, y, color;

	//TODO: ���̓G���[����
	cout << "�c�������\n��";
	l=inputInt();
	cout << "���������\n��";
	w=inputInt();
	cout << "�����x���W�����\n��";
	cin >> x;
	cout << "�����y���W�����\n��";
	cin >> y;
	cout << "�����`�̐F���w��\n1: red\n2: blue\n3: yellow\n4: gray\n�Ή�����F�̔ԍ������\n��";
	cin >> color;

	Rectangle *r = new Rectangle(l, w, x, y,color);
	//r���{�[�h�ɔz�u�ł��钷���`�ł��邩���`�F�b�N

	board.onBoardRect.push_back(*r);
}

void Command::deleteCmd() {
	//TODO: ���̓G���[����
	int n;
	displayBoardCmd();
	std::cout << "�{�[�h����폜�����������`��I��\n��";
	std::cin >> n;

	//�폜�����������`�ɃA�N�Z�X���č폜
	auto itr = board.onBoardRect.begin();
	for (int i = 0; i < n;i++) {
		++itr;
	}
	board.onBoardRect.erase(itr);
}

void Command::displayBoardCmd() {
	int i = 0;
	for (auto &r : board.onBoardRect) {
		std::cout << i + 1 << ": ";
		r.showRectAttribute();
		i++;
	}
}

void Command::exitMsg() {
	isExit = true;
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