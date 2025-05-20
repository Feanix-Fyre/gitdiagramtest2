using System.Runtime.InteropServices;

namespace System;

internal static class ParameterizedStrings
{
	public struct FormatParam
	{
		private readonly int _int32;

		private readonly string _string;

		public int Int32 => 0;

		public string String => null;

		public object Object => null;

		public FormatParam(int value)
		{
			_int32 = 0;
			_string = null;
		}

		private FormatParam(int intValue, string stringValue)
		{
			_int32 = 0;
			_string = null;
		}

		public static implicit operator FormatParam(int value)
		{
			return default(FormatParam);
		}
	}

	private sealed class LowLevelStack
	{
		private FormatParam[] _arr;

		private int _count;

		public FormatParam Pop()
		{
			return default(FormatParam);
		}

		public void Push(FormatParam item)
		{
		}

		public void Clear()
		{
		}
	}

	[ThreadStatic]
	private static LowLevelStack _cachedStack;

	public static string Evaluate(string format, params FormatParam[] args)
	{
		return null;
	}

	private static string EvaluateInternal(string format, ref int pos, FormatParam[] args, LowLevelStack stack, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars)
	{
		return null;
	}

	private static bool AsBool(int i)
	{
		return false;
	}

	private static int AsInt(bool b)
	{
		return 0;
	}

	private static string StringFromAsciiBytes(byte[] buffer, int offset, int length)
	{
		return null;
	}

	[PreserveSig]
	private unsafe static extern int snprintf(byte* str, IntPtr size, string format, string arg1);

	[PreserveSig]
	private unsafe static extern int snprintf(byte* str, IntPtr size, string format, int arg1);

	private static string FormatPrintF(string format, object arg)
	{
		return null;
	}

	private static FormatParam[] GetDynamicOrStaticVariables(char c, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars, out int index)
	{
		index = default(int);
		return null;
	}
}
