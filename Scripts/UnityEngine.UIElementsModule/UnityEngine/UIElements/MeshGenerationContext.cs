using System;
using Unity.Profiling;

namespace UnityEngine.UIElements;

public class MeshGenerationContext
{
	[Flags]
	internal enum MeshFlags
	{
		None = 0,
		UVisDisplacement = 1,
		SkipDynamicAtlas = 2
	}

	private Painter2D m_Painter2D;

	private static readonly ProfilerMarker s_AllocateMarker;

	private static readonly ProfilerMarker s_DrawVectorImageMarker;

	internal IStylePainter painter;

	public Painter2D painter2D => null;

	internal bool hasPainter2D => false;

	internal MeshGenerationContext(IStylePainter painter)
	{
	}
}
