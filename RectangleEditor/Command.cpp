#include "Command.h"

Command::Command() :
	isExit(false)
{
}

void Command::exitMsg() {
	isExit = true;
}