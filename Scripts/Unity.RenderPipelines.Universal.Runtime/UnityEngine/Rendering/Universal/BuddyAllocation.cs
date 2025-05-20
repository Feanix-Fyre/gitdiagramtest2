using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

internal struct BuddyAllocation
{
	public int level;

	public int index;

	public uint2 index2D => default(uint2);

	public BuddyAllocation(int level, int index)
	{
		this.level = 0;
		this.index = 0;
	}
}
