using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

public class Painter2D : IDisposable
{
	private MeshGenerationContext m_Ctx;

	internal DetachedAllocator m_DetachedAllocator;

	internal SafeHandleAccess m_Handle;

	private bool m_Disposed;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static bool _003CisPainterActive_003Ek__BackingField;

	private static float s_MaxArcRadius;

	private static readonly ProfilerMarker s_StrokeMarker;

	private static readonly ProfilerMarker s_FillMarker;

	internal static bool isPainterActive
	{
		[CompilerGenerated]
		set
		{
			_003CisPainterActive_003Ek__BackingField = value;
		}
	}

	internal Painter2D(MeshGenerationContext ctx)
	{
	}

	internal void Reset()
	{
	}

	public void Dispose()
	{
	}

	private void Dispose(bool disposing)
	{
	}
}
