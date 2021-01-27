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

	//�d�����Ȃ��C����10�����ł����push
	if (board.isDuplicating(*r)) {
		std::cout << "���ɓ��������`�����݂��Ă��܂�\n" << std::endl;
	} else if (board.countRects()>=10) {
		std::cout << "�{�[�h��̒����`���ő���𒴂��Ă��܂�" << std::endl;
	}else {
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

	Rectangle r = 

	
	/*�A���S���Y��
	* �P�D�����`R���w�肳����
	* �Q�D�w�肵���ԍ��̒����`���Ăяo��
	* �iC++��List�͒��ڌĂяo���֐����Ȃ��D�ȉ��Ăяo�����@�j
	* auto itr = board.onBoardRect.begin();
	   for (int i = 0; i < n-1;i++) {
	   ++itr;
	}
	Rectangle r = *itr;
	*itr�͗v�f���w���|�C���^�炵���D�Ƃɂ������������n�Ԗڂ̗v�f�ɃA�N�Z�X�ł��邩�Ǝv��
	* �R�D�Ăяo���������`��x, y���W������������
	*/
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
	int i = 0;
	if (board.countRects() == 0) {
		std::cout << "�{�[�h��ɒ����`������܂���" << std::endl;
	} else {
		for (int i = 0; i < board.countRects();i++) {
			Rectangle r = board.getRect(i);
			std::cout << i + 1 << ": ";
			r.showRectAttribute();
			i++;
		}
	}
}

void Command::exitMsg() {
	isExit = true;
}