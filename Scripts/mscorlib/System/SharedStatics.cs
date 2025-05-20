using System.Security.Util;

namespace System;

internal sealed class SharedStatics
{
	private static readonly SharedStatics _sharedStatics;

	private Tokenizer.StringMaker _maker;

	private SharedStatics()
	{
	}

	public static Tokenizer.StringMaker GetSharedStringMaker()
	{
		return null;
	}

	public static void ReleaseSharedStringMaker(ref Tokenizer.StringMaker maker)
	{
	}
}
