#pragma once

class Command {
public:
	Command();

	enum command {
		CREATE=1,
		DELETE=2
	};

	void createCmd();
	void deleteCmd();
	//exit�t���O�𗧂Ă�
	void exitMsg();	

	bool getIsExit() { return isExit; }
private:
	//���[�v���o�邩�o�Ȃ����̃t���O
	bool isExit;
};