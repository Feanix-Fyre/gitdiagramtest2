namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
public struct UnsafeHashMapBucketData
{
	public unsafe readonly byte* values;

	public unsafe readonly byte* keys;

	public unsafe readonly byte* next;

	public unsafe readonly byte* buckets;

	public readonly int bucketCapacityMask;

	internal unsafe UnsafeHashMapBucketData(byte* v, byte* k, byte* n, byte* b, int bcm)
	{
		values = null;
		keys = null;
		next = null;
		buckets = null;
		bucketCapacityMask = 0;
	}
}
