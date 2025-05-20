using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct ShadowSplitData : IEquatable<ShadowSplitData>
{
	private const int k_MaximumCullingPlaneCount = 10;

	public static readonly int maximumCullingPlaneCount;

	private int m_CullingPlaneCount;

	internal unsafe fixed byte m_CullingPlanes[160];

	private Vector4 m_CullingSphere;

	private float m_ShadowCascadeBlendCullingFactor;

	private float m_CullingNearPlane;

	private Matrix4x4 m_CullingMatrix;

	public int cullingPlaneCount => 0;

	public Vector4 cullingSphere => default(Vector4);

	public float shadowCascadeBlendCullingFactor
	{
		set
		{
		}
	}

	public Plane GetCullingPlane(int index)
	{
		return default(Plane);
	}

	public bool Equals(ShadowSplitData other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
