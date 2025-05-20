namespace System;

internal interface IConsoleDriver
{
	ConsoleKeyInfo ReadKey(bool intercept);
}
