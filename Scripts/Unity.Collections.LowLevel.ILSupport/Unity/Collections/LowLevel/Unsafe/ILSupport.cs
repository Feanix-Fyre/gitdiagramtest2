using System.Runtime.CompilerServices;

namespace Unity.Collections.LowLevel.Unsafe;

internal static class ILSupport
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe static void* AddressOf<T>(in T thing) where T : struct
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ref T AsRef<T>(in T thing) where T : struct
	{
		throw null;
	}
}
