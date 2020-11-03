#include "Command.h"

Command::Command() :
	isExit(false)
{
}

void Command::createCmd() {
	int l, w, x, y;

	//TODO: ���̓G���[����
	std::cout << "�c�������\n��";
	std::cin >> l;
	std::cout << "���������\n��";
	std::cin >> w;
	std::cout << "�����x���W�����\n��";
	std::cin >> x;
	std::cout << "�����y���W�����\n��";
	std::cin >> y;

	Rectangle *r = new Rectangle(l, w, x, y);
	board.getRectList().push_back(*r);
}

void Command::deleteCmd() {
	//TODO: ���̓G���[����
	int n;
	std::cout << "�{�[�h����폜�����������`��I��\n��";
	std::cin >> n;

	//�폜�����������`�ɃA�N�Z�X���č폜
	//TODO: itr���������폜�ԍ��ɓ��B���Ă��邩�ǂ����̊m�F�K�v
	auto itr = board.getRectList().begin();
	for (int i = 0; i < n;i++) {
		++itr;
	}
	board.getRectList().erase(itr);
}

void Command::displayBoardCmd() {
	for (auto &r : board.getRectList()) {
		r.showRectAttribute();
	}
}

void Command::exitMsg() {
	isExit = true;
}