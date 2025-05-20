using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering;

public class XRPass
{
	private readonly List<XRView> m_Views;

	private readonly XROcclusionMesh m_OcclusionMesh;

	public bool enabled => false;

	public bool supportsFoveatedRendering => false;

	public bool copyDepth { get; private set; }

	public int multipassId { get; private set; }

	public int cullingPassId { get; private set; }

	public RenderTargetIdentifier renderTarget { get; private set; }

	public RenderTextureDescriptor renderTargetDesc { get; private set; }

	public ScriptableCullingParameters cullingParams { get; private set; }

	public int viewCount => 0;

	public bool singlePassEnabled => false;

	public IntPtr foveatedRenderingInfo { get; private set; }

	public bool isHDRDisplayOutputActive => false;

	public ColorGamut hdrDisplayOutputColorGamut => default(ColorGamut);

	public HDROutputUtils.HDRDisplayInformation hdrDisplayOutputInformation => default(HDROutputUtils.HDRDisplayInformation);

	public bool hasValidOcclusionMesh => false;

	public static XRPass CreateDefault(XRPassCreateInfo createInfo)
	{
		return null;
	}

	public virtual void Release()
	{
	}

	public Matrix4x4 GetProjMatrix(int viewIndex = 0)
	{
		return default(Matrix4x4);
	}

	public Matrix4x4 GetViewMatrix(int viewIndex = 0)
	{
		return default(Matrix4x4);
	}

	public Rect GetViewport(int viewIndex = 0)
	{
		return default(Rect);
	}

	public Mesh GetOcclusionMesh(int viewIndex = 0)
	{
		return null;
	}

	public int GetTextureArraySlice(int viewIndex = 0)
	{
		return 0;
	}

	public void StartSinglePass(CommandBuffer cmd)
	{
	}

	public void StopSinglePass(CommandBuffer cmd)
	{
	}

	public void RenderOcclusionMesh(CommandBuffer cmd)
	{
	}

	public Vector4 ApplyXRViewCenterOffset(Vector2 center)
	{
		return default(Vector4);
	}

	internal void AssignView(int viewId, XRView xrView)
	{
	}

	internal void AssignCullingParams(int cullingPassId, ScriptableCullingParameters cullingParams)
	{
	}

	internal void UpdateCombinedOcclusionMesh()
	{
	}

	public void InitBase(XRPassCreateInfo createInfo)
	{
	}

	internal void AddView(XRView xrView)
	{
	}
}
