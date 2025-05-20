using System.Text;
using UnityEngine.Bindings;

namespace UnityEngine;

[VisibleToOtherModules(new string[] { "UnityEngine.UnityWebRequestWWWModule" })]
internal class WWWTranscoder
{
	private static byte[] ucHexChars;

	private static byte[] lcHexChars;

	private static byte urlEscapeChar;

	private static byte[] urlSpace;

	private static byte[] dataSpace;

	private static byte[] urlForbidden;

	private static byte qpEscapeChar;

	private static byte[] qpSpace;

	private static byte[] qpForbidden;

	private static byte Hex2Byte(byte[] b, int offset)
	{
		return 0;
	}

	private static void Byte2Hex(byte b, byte[] hexChars, out byte byte0, out byte byte1)
	{
		byte0 = default(byte);
		byte1 = default(byte);
	}

	public static byte[] DataEncode(byte[] toEncode)
	{
		return null;
	}

	public static string QPEncode(string toEncode, Encoding e)
	{
		return null;
	}

	public static byte[] Encode(byte[] input, byte escapeChar, byte[] space, byte[] forbidden, bool uppercase)
	{
		return null;
	}

	private static bool ByteArrayContains(byte[] array, byte b)
	{
		return false;
	}

	public static byte[] URLDecode(byte[] toEncode)
	{
		return null;
	}

	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand)
	{
		return false;
	}

	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space)
	{
		return null;
	}

	public static bool SevenBitClean(string s, Encoding e)
	{
		return false;
	}

	public unsafe static bool SevenBitClean(byte* input, int inputLength)
	{
		return false;
	}
}
