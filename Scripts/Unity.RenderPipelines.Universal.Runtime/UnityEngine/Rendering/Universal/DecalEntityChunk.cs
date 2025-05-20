using Unity.Collections;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering.Universal;

internal class DecalEntityChunk : DecalChunk
{
	public Material material;

	public NativeArray<DecalEntity> decalEntities;

	public DecalProjector[] decalProjectors;

	public TransformAccessArray transformAccessArray;

	public override void Push()
	{
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
