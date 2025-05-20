using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

internal sealed class MotionVectorRenderPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle motionVectorColor;

		internal TextureHandle motionVectorDepth;

		internal TextureHandle cameraDepth;

		internal RenderingData renderingData;

		internal Material cameraMaterial;

		internal Material objectMaterial;
	}

	private const string kPreviousViewProjectionNoJitter = "_PrevViewProjMatrix";

	private const string kViewProjectionNoJitter = "_NonJitteredViewProjMatrix";

	private const string kPreviousViewProjectionNoJitterStereo = "_PrevViewProjMatrixStereo";

	private const string kViewProjectionNoJitterStereo = "_NonJitteredViewProjMatrixStereo";

	internal const GraphicsFormat k_TargetFormat = GraphicsFormat.R16G16_SFloat;

	private static readonly string[] s_ShaderTags;

	private RTHandle m_Color;

	private RTHandle m_Depth;

	private readonly Material m_CameraMaterial;

	private readonly Material m_ObjectMaterial;

	private PassData m_PassData;

	internal MotionVectorRenderPass(RenderPassEvent evt, Material cameraMaterial, Material objectMaterial)
	{
	}

	internal void Setup(RTHandle color, RTHandle depth)
	{
	}

	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
	}

	private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private static DrawingSettings GetDrawingSettings(ref RenderingData renderingData, Material objectMaterial)
	{
		return default(DrawingSettings);
	}

	private static void DrawCameraMotionVectors(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, Camera camera, Material cameraMaterial)
	{
	}

	private static void DrawObjectMotionVectors(ScriptableRenderContext context, ref RenderingData renderingData, Camera camera, Material objectMaterial, CommandBuffer cmd)
	{
	}

	internal void Render(RenderGraph renderGraph, ref TextureHandle cameraDepthTexture, in TextureHandle motionVectorColor, in TextureHandle motionVectorDepth, ref RenderingData renderingData)
	{
	}
}
