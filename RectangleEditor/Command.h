#pragma once

class Command {
public:
	Command();

	enum command {
		CREATE,
		DELETE
	};

	void create_cmd();
	void delete_cmd();
private:
};