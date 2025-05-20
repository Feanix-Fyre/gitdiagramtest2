using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering.Universal;

internal class DecalUpdateCachedSystem
{
	[BurstCompile]
	public struct UpdateTransformsJob : IJobParallelForTransform
	{
		private static readonly quaternion k_MinusYtoZRotation;

		public NativeArray<float3> positions;

		public NativeArray<quaternion> rotations;

		public NativeArray<float3> scales;

		public NativeArray<bool> dirty;

		[ReadOnly]
		public NativeArray<DecalScaleMode> scaleModes;

		[ReadOnly]
		public NativeArray<float4x4> sizeOffsets;

		[WriteOnly]
		public NativeArray<float4x4> decalToWorlds;

		[WriteOnly]
		public NativeArray<float4x4> normalToWorlds;

		[WriteOnly]
		public NativeArray<BoundingSphere> boundingSpheres;

		public float minDistance;

		private float DistanceBetweenQuaternions(quaternion a, quaternion b)
		{
			return 0f;
		}

		public void Execute(int index, TransformAccess transform)
		{
		}

		private BoundingSphere GetDecalProjectBoundingSphere(Matrix4x4 decalToWorld)
		{
			return default(BoundingSphere);
		}
	}

	private DecalEntityManager m_EntityManager;

	private ProfilingSampler m_Sampler;

	private ProfilingSampler m_SamplerJob;

	public DecalUpdateCachedSystem(DecalEntityManager entityManager)
	{
	}

	public void Execute()
	{
	}

	private void Execute(DecalEntityChunk entityChunk, DecalCachedChunk cachedChunk, int count)
	{
	}
}
