using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

internal class DecalDrawCallChunk : DecalChunk
{
	public NativeArray<float4x4> decalToWorlds;

	public NativeArray<float4x4> normalToDecals;

	public NativeArray<float> renderingLayerMasks;

	public NativeArray<DecalSubDrawCall> subCalls;

	public NativeArray<int> subCallCounts;

	public int subCallCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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
