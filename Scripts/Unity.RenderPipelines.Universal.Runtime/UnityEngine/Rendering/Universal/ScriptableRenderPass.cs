using System;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public abstract class ScriptableRenderPass
{
	public static RTHandle k_CameraTarget;

	private RenderBufferStoreAction[] m_ColorStoreActions;

	private RenderBufferStoreAction m_DepthStoreAction;

	private bool[] m_OverriddenColorStoreActions;

	private bool m_OverriddenDepthStoreAction;

	internal NativeArray<int> m_ColorAttachmentIndices;

	internal NativeArray<int> m_InputAttachmentIndices;

	internal bool m_UsesRTHandles;

	private RTHandle[] m_ColorAttachments;

	private RenderTargetIdentifier[] m_ColorAttachmentIds;

	internal RTHandle[] m_InputAttachments;

	internal bool[] m_InputAttachmentIsTransient;

	private RTHandle m_DepthAttachment;

	private RenderTargetIdentifier m_DepthAttachmentId;

	private ScriptableRenderPassInput m_Input;

	private ClearFlag m_ClearFlag;

	private Color m_ClearColor;

	public RenderPassEvent renderPassEvent { get; set; }

	[Obsolete("Use colorAttachmentHandles")]
	public RenderTargetIdentifier[] colorAttachments => null;

	[Obsolete("Use colorAttachmentHandle")]
	public RenderTargetIdentifier colorAttachment => default(RenderTargetIdentifier);

	[Obsolete("Use depthAttachmentHandle")]
	public RenderTargetIdentifier depthAttachment => default(RenderTargetIdentifier);

	public RTHandle[] colorAttachmentHandles => null;

	public RTHandle colorAttachmentHandle => null;

	public RTHandle depthAttachmentHandle => null;

	public RenderBufferStoreAction[] colorStoreActions => null;

	public RenderBufferStoreAction depthStoreAction => default(RenderBufferStoreAction);

	internal bool[] overriddenColorStoreActions => null;

	internal bool overriddenDepthStoreAction => false;

	public ScriptableRenderPassInput input => default(ScriptableRenderPassInput);

	public ClearFlag clearFlag => default(ClearFlag);

	public Color clearColor => default(Color);

	protected internal ProfilingSampler profilingSampler { get; set; }

	internal bool overrideCameraTarget { get; set; }

	internal bool isBlitRenderPass { get; set; }

	internal bool useNativeRenderPass { get; set; }

	internal int renderPassQueueIndex { get; set; }

	internal GraphicsFormat[] renderTargetFormat { get; set; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual void FrameCleanup(CommandBuffer cmd)
	{
	}

	internal static DebugHandler GetActiveDebugHandler(ref RenderingData renderingData)
	{
		return null;
	}

	public ScriptableRenderPass()
	{
	}

	public void ConfigureInput(ScriptableRenderPassInput passInput)
	{
	}

	public void ConfigureColorStoreAction(RenderBufferStoreAction storeAction, uint attachmentIndex = 0u)
	{
	}

	public void ConfigureColorStoreActions(RenderBufferStoreAction[] storeActions)
	{
	}

	public void ConfigureDepthStoreAction(RenderBufferStoreAction storeAction)
	{
	}

	internal void ConfigureInputAttachments(RTHandle input, bool isTransient = false)
	{
	}

	internal void ConfigureInputAttachments(RTHandle[] inputs)
	{
	}

	internal void ConfigureInputAttachments(RTHandle[] inputs, bool[] isTransient)
	{
	}

	internal void SetInputAttachmentTransient(int idx, bool isTransient)
	{
	}

	internal bool IsInputAttachmentTransient(int idx)
	{
		return false;
	}

	public void ResetTarget()
	{
	}

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
	{
	}

	public void ConfigureTarget(RTHandle colorAttachment, RTHandle depthAttachment)
	{
	}

	[Obsolete("Use RTHandles for colorAttachments and depthAttachment")]
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment)
	{
	}

	public void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment)
	{
	}

	internal void ConfigureTarget(RTHandle[] colorAttachments, RTHandle depthAttachment, GraphicsFormat[] formats)
	{
	}

	[Obsolete("Use RTHandle for colorAttachment")]
	public void ConfigureTarget(RenderTargetIdentifier colorAttachment)
	{
	}

	public void ConfigureTarget(RTHandle colorAttachment)
	{
	}

	[Obsolete("Use RTHandles for colorAttachments")]
	public void ConfigureTarget(RenderTargetIdentifier[] colorAttachments)
	{
	}

	public void ConfigureTarget(RTHandle[] colorAttachments)
	{
	}

	public void ConfigureClear(ClearFlag clearFlag, Color clearColor)
	{
	}

	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
	}

	public virtual void OnCameraCleanup(CommandBuffer cmd)
	{
	}

	public virtual void OnFinishCameraStackRendering(CommandBuffer cmd)
	{
	}

	public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData);

	internal virtual void RecordRenderGraph(RenderGraph renderGraph, ref RenderingData renderingData)
	{
	}

	[Obsolete("Use RTHandles for source and destination")]
	public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0)
	{
	}

	public void Blit(CommandBuffer cmd, RTHandle source, RTHandle destination, Material material = null, int passIndex = 0)
	{
	}

	public void Blit(CommandBuffer cmd, ref RenderingData data, Material material, int passIndex = 0)
	{
	}

	public void Blit(CommandBuffer cmd, ref RenderingData data, RTHandle source, Material material, int passIndex = 0)
	{
	}

	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
	{
		return default(DrawingSettings);
	}

	public DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
	{
		return default(DrawingSettings);
	}

	public static bool operator <(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
	{
		return false;
	}

	public static bool operator >(ScriptableRenderPass lhs, ScriptableRenderPass rhs)
	{
		return false;
	}

	internal static int GetRenderPassEventRange(RenderPassEvent renderPassEvent)
	{
		return 0;
	}
}
