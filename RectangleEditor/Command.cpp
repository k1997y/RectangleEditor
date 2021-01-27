#include "Command.h"

Command::Command() :
	isExit(false)
{
}

void Command::createCmd() {
	int l, w, x, y, color;

	//TODO: ���̓G���[����
	std::cout << "�c�������\n��";
	std::cin >> l;
	std::cout << "���������\n��";
	std::cin >> w;
	std::cout << "�����x���W�����\n��";
	std::cin >> x;
	std::cout << "�����y���W�����\n��";
	std::cin >> y;
	std::cout << "�F�����\n(1: red, 2: blue, 3: yellow, 4: gray)\n-->";
	std::cin >> color;

	Rectangle *r = new Rectangle(l, w, x, y,color);

	//�d�����Ȃ��C����10�����ł����push
	if (board.isDuplicating(*r)) {
		std::cout << "���ɓ��������`�����݂��Ă��܂�\n" << std::endl;
	} else if (board.countRects() >= 10) {
		std::cout << "�{�[�h��̒����`���ő���𒴂��Ă��܂�" << std::endl;
	} else {
		board.addRect(*r);
		std::cout << "�w�肳�ꂽ�l�̒����`���쐬���܂���" << std::endl;
		displayBoardCmd();
	}
}

//�I�����������`���w�蕪�����ړ�
void Command::moveCmd() {
	int i;
	std::cout << "�����`��I��\n-->";
	std::cin >> i;

	Rectangle r = board.getRect(i-1);

	int x, y;
	std::cout << "x�����̈ړ�����\n-->";
	std::cin >> x;
	std::cout << "y�����̈ړ�����\n-->";
	std::cin >> y;

	int *attribute = new int[5];

	attribute = r.getAttribute();
	attribute[2] = attribute[2] + x;
	attribute[3] = attribute[3] + y;

	r.setAttribute(attribute);	

	board.replaceRect(r, i);
	std::cout << "�����`" << i << "���w�苗�����ړ����܂���\n";
	displayBoardCmd();
}

void Command::deleteCmd() {
	//TODO: ���̓G���[����
	int n;
	if (board.countRects() == 0) {
		std::cout << "�{�[�h��ɒ����`������܂���" << std::endl;
		return;
	}

	displayBoardCmd();
	std::cout << "�{�[�h����폜�����������`��I��\n��";
	std::cin >> n;

	board.deleteRect(n);
	std::cout << "�����`" << n << "���폜���܂���" << std::endl;
	displayBoardCmd();
}

void Command::displayBoardCmd() {
	if (board.countRects() == 0) {
		std::cout << "�{�[�h��ɒ����`������܂���" << std::endl;
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