#include "Command.h"

Command::Command() :
	isExit(false)
{
}

void Command::createCmd() {
	
}

void Command::deleteCmd() {

}

void Command::exitMsg() {
	isExit = true;
}