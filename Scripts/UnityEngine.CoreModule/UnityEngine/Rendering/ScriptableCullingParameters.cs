using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct ScriptableCullingParameters : IEquatable<ScriptableCullingParameters>
{
	private int m_IsOrthographic;

	private LODParameters m_LODParameters;

	private const int k_MaximumCullingPlaneCount = 10;

	public static readonly int maximumCullingPlaneCount;

	internal unsafe fixed byte m_CullingPlanes[160];

	private int m_CullingPlaneCount;

	private uint m_CullingMask;

	private ulong m_SceneMask;

	private ulong m_ViewID;

	private const int k_LayerCount = 32;

	public static readonly int layerCount;

	internal unsafe fixed float m_LayerFarCullDistances[32];

	private int m_LayerCull;

	private Matrix4x4 m_CullingMatrix;

	private Vector3 m_Origin;

	private float m_ShadowDistance;

	private float m_ShadowNearPlaneOffset;

	private CullingOptions m_CullingOptions;

	private ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria;

	private CameraProperties m_CameraProperties;

	private float m_AccurateOcclusionThreshold;

	private int m_MaximumPortalCullingJobs;

	private const int k_CullingJobCountLowerLimit = 1;

	private const int k_CullingJobCountUpperLimit = 16;

	private Matrix4x4 m_StereoViewMatrix;

	private Matrix4x4 m_StereoProjectionMatrix;

	private float m_StereoSeparationDistance;

	private int m_maximumVisibleLights;

	private bool m_ConservativeEnclosingSphere;

	private int m_NumIterationsEnclosingSphere;

	public int maximumVisibleLights
	{
		set
		{
		}
	}

	public bool conservativeEnclosingSphere
	{
		set
		{
		}
	}

	public int numIterationsEnclosingSphere
	{
		set
		{
		}
	}

	public int cullingPlaneCount => 0;

	public bool isOrthographic
	{
		set
		{
		}
	}

	public float shadowDistance
	{
		set
		{
		}
	}

	public CullingOptions cullingOptions
	{
		get
		{
			return default(CullingOptions);
		}
		set
		{
		}
	}

	public ReflectionProbeSortingCriteria reflectionProbeSortingCriteria
	{
		set
		{
		}
	}

	public Matrix4x4 stereoViewMatrix
	{
		set
		{
		}
	}

	public Matrix4x4 stereoProjectionMatrix
	{
		get
		{
			return default(Matrix4x4);
		}
		set
		{
		}
	}

	public float stereoSeparationDistance
	{
		set
		{
		}
	}

	public float GetLayerCullingDistance(int layerIndex)
	{
		return 0f;
	}

	public Plane GetCullingPlane(int index)
	{
		return default(Plane);
	}

	public bool Equals(ScriptableCullingParameters other)
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
