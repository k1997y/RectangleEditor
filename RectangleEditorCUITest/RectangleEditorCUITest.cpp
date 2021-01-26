#include "../RectangleEditor/Command.h"
#include "pch.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace RectangleEditorCUITest{
	TEST_CLASS(RectangleEditorCUITest){
		public:
			Command cmd;

		TEST_METHOD(create_11ŒÂ){
			for (int i = 0; i < 10; i++) {
				Rectangle *r = new Rectangle(i, i, 10, 10, 1);
			}
		}
	};
}
