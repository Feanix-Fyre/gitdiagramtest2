using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
{
	private class QualityPreset
	{
		public int maximumIterationCount;

		public float thickness;

		public ScreenSpaceReflectionResolution downsampling;
	}

	private enum Pass
	{
		Test = 0,
		Resolve = 1,
		Reproject = 2,
		Composite = 3
	}

	private RenderTexture m_Resolve;

	private RenderTexture m_History;

	private int[] m_MipIDs;

	private readonly QualityPreset[] m_Presets;

	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap)
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}

	public override void Release()
	{
	}
}
