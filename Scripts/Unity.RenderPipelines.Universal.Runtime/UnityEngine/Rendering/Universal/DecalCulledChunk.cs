using Unity.Collections;

namespace UnityEngine.Rendering.Universal;

internal class DecalCulledChunk : DecalChunk
{
	public Vector3 cameraPosition;

	public ulong sceneCullingMask;

	public int cullingMask;

	public CullingGroup cullingGroups;

	public int[] visibleDecalIndexArray;

	public NativeArray<int> visibleDecalIndices;

	public int visibleDecalCount;

	public override void RemoveAtSwapBack(int entityIndex)
	{
	}

	public override void SetCapacity(int newCapacity)
	{
	}

	public override void Dispose()
	{
	}
}
