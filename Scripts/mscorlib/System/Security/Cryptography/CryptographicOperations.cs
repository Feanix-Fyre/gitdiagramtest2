using System.Runtime.CompilerServices;

namespace System.Security.Cryptography;

public static class CryptographicOperations
{
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static void ZeroMemory(Span<byte> buffer)
	{
	}
}
