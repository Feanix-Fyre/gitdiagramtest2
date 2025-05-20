using System;
using Unity.Collections;

namespace UnityEngine.Rendering;

public struct RendererListParams : IEquatable<RendererListParams>
{
	public static readonly RendererListParams Invalid;

	public CullingResults cullingResults;

	public DrawingSettings drawSettings;

	public FilteringSettings filteringSettings;

	public ShaderTagId tagName;

	public bool isPassTagName;

	public NativeArray<ShaderTagId>? tagValues;

	public NativeArray<RenderStateBlock>? stateBlocks;

	internal int numStateBlocks => 0;

	internal IntPtr stateBlocksPtr => (IntPtr)0;

	internal IntPtr tagsValuePtr => (IntPtr)0;

	internal void Dispose()
	{
	}

	internal void Validate()
	{
	}

	public bool Equals(RendererListParams other)
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
