using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing;

internal class TextureLerper
{
	private static TextureLerper m_Instance;

	private CommandBuffer m_Command;

	private PropertySheetFactory m_PropertySheets;

	private PostProcessResources m_Resources;

	private List<RenderTexture> m_Recycled;

	private List<RenderTexture> m_Actives;

	internal static TextureLerper instance => null;

	private TextureLerper()
	{
	}

	internal void BeginFrame(PostProcessRenderContext context)
	{
	}

	internal void EndFrame()
	{
	}

	private RenderTexture Get(RenderTextureFormat format, int w, int h, int d = 1, bool enableRandomWrite = false, bool force3D = false)
	{
		return null;
	}

	internal Texture Lerp(Texture from, Texture to, float t)
	{
		return null;
	}

	internal Texture Lerp(Texture from, Color to, float t)
	{
		return null;
	}

	internal void Clear()
	{
	}
}
