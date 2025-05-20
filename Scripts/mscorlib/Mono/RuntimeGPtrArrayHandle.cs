using System;

namespace Mono;

internal struct RuntimeGPtrArrayHandle
{
	private unsafe RuntimeStructs.GPtrArray* value;

	internal int Length => 0;

	internal IntPtr this[int i] => (IntPtr)0;

	internal unsafe RuntimeGPtrArrayHandle(IntPtr ptr)
	{
		value = null;
	}

	internal IntPtr Lookup(int i)
	{
		return (IntPtr)0;
	}

	private unsafe static void GPtrArrayFree(RuntimeStructs.GPtrArray* value)
	{
	}

	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h)
	{
	}
}
