#include "Command.h"

Command::Command() :
	isExit(false)
{
}

//TODO: �����`����10�ɐ���
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
	//�d�����Ȃ����push
	if (board.isDuplicating(*r)) {
		std::cout << "���ɓ��������`�����݂��Ă��܂�\n" << std::endl;
	} else {
		board.onBoardRect.push_back(*r);
	}
}

//TODO: �{�[�h��ɒ����`�������ꍇ�̏���
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

//TODO: �{�[�h��̒����`��0�̂Ƃ��̏���
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