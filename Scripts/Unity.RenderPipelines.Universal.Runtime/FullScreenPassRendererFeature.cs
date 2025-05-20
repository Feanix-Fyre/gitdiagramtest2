using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class FullScreenPassRendererFeature : ScriptableRendererFeature, ISerializationCallbackReceiver
{
	public enum InjectionPoint
	{
		BeforeRenderingTransparents = 450,
		BeforeRenderingPostProcessing = 550,
		AfterRenderingPostProcessing = 600
	}

	internal class FullScreenRenderPass : ScriptableRenderPass
	{
		private Material m_Material;

		private int m_PassIndex;

		private bool m_CopyActiveColor;

		private bool m_BindDepthStencilAttachment;

		private RTHandle m_CopiedColor;

		private static MaterialPropertyBlock s_SharedPropertyBlock;

		public FullScreenRenderPass(string passName)
		{
		}

		public void SetupMembers(Material material, int passIndex, bool copyActiveColor, bool bindDepthStencilAttachment)
		{
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		internal void ReAllocate(RenderTextureDescriptor desc)
		{
		}

		public void Dispose()
		{
		}

		private static void ExecuteCopyColorPass(CommandBuffer cmd, RTHandle sourceTexture)
		{
		}

		private static void ExecuteMainPass(CommandBuffer cmd, RTHandle sourceTexture, Material material, int passIndex)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}

	private enum Version
	{
		Uninitialised = -1,
		Initial = 0,
		AddFetchColorBufferCheckbox = 1,
		Count = 2,
		Latest = 1
	}

	public InjectionPoint injectionPoint;

	public bool fetchColorBuffer;

	public ScriptableRenderPassInput requirements;

	public Material passMaterial;

	internal bool showAdditionalProperties;

	public int passIndex;

	public bool bindDepthStencilAttachment;

	private FullScreenRenderPass m_FullScreenPass;

	[SerializeField]
	[HideInInspector]
	private Version m_Version;

	public override void Create()
	{
	}

	internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
	{
		atEvent = default(RenderingLayerUtils.Event);
		maskSize = default(RenderingLayerUtils.MaskSize);
		return false;
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void UpgradeIfNeeded()
	{
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}
}
