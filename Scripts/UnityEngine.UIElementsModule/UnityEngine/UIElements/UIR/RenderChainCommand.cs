using System;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand>
{
	internal VisualElement owner;

	internal RenderChainCommand prev;

	internal RenderChainCommand next;

	internal bool closing;

	internal CommandType type;

	internal State state;

	internal MeshHandle mesh;

	internal int indexOffset;

	internal int indexCount;

	internal Action callback;

	private static readonly int k_ID_MainTex;

	private static ProfilerMarker s_ImmediateOverheadMarker;

	internal void Reset()
	{
	}

	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException)
	{
	}

	private void Blit(Texture source, RenderTexture destination, float depth)
	{
	}

	private static Rect CombineScissorRects(Rect r0, Rect r1)
	{
		return default(Rect);
	}

	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint)
	{
		return default(RectInt);
	}
}
