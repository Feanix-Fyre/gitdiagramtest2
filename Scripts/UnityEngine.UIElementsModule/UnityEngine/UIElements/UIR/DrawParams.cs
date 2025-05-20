using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR;

internal class DrawParams
{
	internal static readonly Rect k_UnlimitedRect;

	internal static readonly Rect k_FullNormalizedRect;

	internal readonly Stack<Matrix4x4> view;

	internal readonly Stack<Rect> scissor;

	internal readonly List<RenderTexture> renderTexture;

	internal readonly List<Material> defaultMaterial;

	public void Reset()
	{
	}
}
