using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct ShadowDrawingSettings : IEquatable<ShadowDrawingSettings>
{
	private CullingResults m_CullingResults;

	private int m_LightIndex;

	private int m_UseRenderingLayerMaskTest;

	private ShadowSplitData m_SplitData;

	private ShadowObjectsFilter m_ObjectsFilter;

	private BatchCullingProjectionType m_ProjectionType;

	public bool useRenderingLayerMaskTest
	{
		set
		{
		}
	}

	public ShadowSplitData splitData
	{
		set
		{
		}
	}

	public ShadowDrawingSettings(CullingResults cullingResults, int lightIndex, BatchCullingProjectionType projectionType)
	{
		m_CullingResults = default(CullingResults);
		m_LightIndex = 0;
		m_UseRenderingLayerMaskTest = 0;
		m_SplitData = default(ShadowSplitData);
		m_ObjectsFilter = default(ShadowObjectsFilter);
		m_ProjectionType = default(BatchCullingProjectionType);
	}

	public bool Equals(ShadowDrawingSettings other)
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
