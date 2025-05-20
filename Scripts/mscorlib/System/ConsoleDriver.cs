using System.Runtime.CompilerServices;

namespace System;

internal static class ConsoleDriver
{
	internal static IConsoleDriver driver;

	private static bool is_console;

	private static bool called_isatty;

	public static bool IsConsole => false;

	static ConsoleDriver()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IConsoleDriver CreateNullConsoleDriver()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IConsoleDriver CreateWindowsConsoleDriver()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IConsoleDriver CreateTermInfoDriver(string term)
	{
		return null;
	}

	public static ConsoleKeyInfo ReadKey(bool intercept)
	{
		return default(ConsoleKeyInfo);
	}

	private static bool Isatty(IntPtr handle)
	{
		return false;
	}

	internal static int InternalKeyAvailable(int ms_timeout)
	{
		return 0;
	}

	internal unsafe static bool TtySetup(string keypadXmit, string teardown, out byte[] control_characters, out int* address)
	{
		control_characters = null;
		Unsafe.As<int*, @null>(ref address) = null;
		return false;
	}

	internal static bool SetEcho(bool wantEcho)
	{
		return false;
	}
}
