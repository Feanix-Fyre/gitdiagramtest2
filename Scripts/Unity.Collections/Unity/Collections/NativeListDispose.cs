using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[BurstCompatible]
[NativeContainer]
internal struct NativeListDispose
{
	[NativeDisableUnsafePtrRestriction]
	public unsafe UntypedUnsafeList* m_ListData;

	public void Dispose()
	{
	}
}
