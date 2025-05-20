using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal;

internal class DecalCreateDrawCallSystem
{
	[BurstCompile]
	private struct DrawCallJob : IJob
	{
		[ReadOnly]
		public NativeArray<float4x4> decalToWorlds;

		[ReadOnly]
		public NativeArray<float4x4> normalToWorlds;

		[ReadOnly]
		public NativeArray<float4x4> sizeOffsets;

		[ReadOnly]
		public NativeArray<float2> drawDistances;

		[ReadOnly]
		public NativeArray<float2> angleFades;

		[ReadOnly]
		public NativeArray<float4> uvScaleBiases;

		[ReadOnly]
		public NativeArray<int> layerMasks;

		[ReadOnly]
		public NativeArray<ulong> sceneLayerMasks;

		[ReadOnly]
		public NativeArray<float> fadeFactors;

		[ReadOnly]
		public NativeArray<BoundingSphere> boundingSpheres;

		[ReadOnly]
		public NativeArray<uint> renderingLayerMasks;

		public Vector3 cameraPosition;

		public ulong sceneCullingMask;

		public int cullingMask;

		[ReadOnly]
		public NativeArray<int> visibleDecalIndices;

		public int visibleDecalCount;

		public float maxDrawDistance;

		[WriteOnly]
		public NativeArray<float4x4> decalToWorldsDraw;

		[WriteOnly]
		public NativeArray<float4x4> normalToDecalsDraw;

		[WriteOnly]
		public NativeArray<float> renderingLayerMasksDraw;

		[WriteOnly]
		public NativeArray<DecalSubDrawCall> subCalls;

		[WriteOnly]
		public NativeArray<int> subCallCount;

		public void Execute()
		{
		}
	}

	private DecalEntityManager m_EntityManager;

	private ProfilingSampler m_Sampler;

	private float m_MaxDrawDistance;

	public float maxDrawDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public DecalCreateDrawCallSystem(DecalEntityManager entityManager, float maxDrawDistance)
	{
	}

	public void Execute()
	{
	}

	private void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, DecalDrawCallChunk drawCallChunk, int count)
	{
	}
}
