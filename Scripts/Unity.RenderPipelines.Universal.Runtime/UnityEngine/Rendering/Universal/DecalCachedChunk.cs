using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

internal class DecalCachedChunk : DecalChunk
{
	public MaterialPropertyBlock propertyBlock;

	public int passIndexDBuffer;

	public int passIndexEmissive;

	public int passIndexScreenSpace;

	public int passIndexGBuffer;

	public int drawOrder;

	public bool isCreated;

	public NativeArray<float4x4> decalToWorlds;

	public NativeArray<float4x4> normalToWorlds;

	public NativeArray<float4x4> sizeOffsets;

	public NativeArray<float2> drawDistances;

	public NativeArray<float2> angleFades;

	public NativeArray<float4> uvScaleBias;

	public NativeArray<int> layerMasks;

	public NativeArray<ulong> sceneLayerMasks;

	public NativeArray<float> fadeFactors;

	public NativeArray<BoundingSphere> boundingSpheres;

	public NativeArray<DecalScaleMode> scaleModes;

	public NativeArray<uint> renderingLayerMasks;

	public NativeArray<float3> positions;

	public NativeArray<quaternion> rotation;

	public NativeArray<float3> scales;

	public NativeArray<bool> dirty;

	public BoundingSphere[] boundingSphereArray;

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
