using System.Runtime.CompilerServices;

namespace System.Threading;

[ReflectionBlocked]
public struct LockHolder : IDisposable
{
	private Lock _lock;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static LockHolder Hold(Lock l)
	{
		return default(LockHolder);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Dispose()
	{
	}
}
