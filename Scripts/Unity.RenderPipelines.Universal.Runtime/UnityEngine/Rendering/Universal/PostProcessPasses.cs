using System;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal;

internal struct PostProcessPasses : IDisposable
{
	private ColorGradingLutPass m_ColorGradingLutPass;

	private PostProcessPass m_PostProcessPass;

	private PostProcessPass m_FinalPostProcessPass;

	internal RTHandle m_AfterPostProcessColor;

	internal RTHandle m_ColorGradingLut;

	private PostProcessData m_RendererPostProcessData;

	private PostProcessData m_CurrentPostProcessData;

	private Material m_BlitMaterial;

	public ColorGradingLutPass colorGradingLutPass => null;

	public PostProcessPass postProcessPass => null;

	public PostProcessPass finalPostProcessPass => null;

	public RTHandle afterPostProcessColor => null;

	public RTHandle colorGradingLut => null;

	public bool isCreated => false;

	public PostProcessPasses(PostProcessData rendererPostProcessData, ref PostProcessParams postProcessParams)
	{
		m_ColorGradingLutPass = null;
		m_PostProcessPass = null;
		m_FinalPostProcessPass = null;
		m_AfterPostProcessColor = null;
		m_ColorGradingLut = null;
		m_RendererPostProcessData = null;
		m_CurrentPostProcessData = null;
		m_BlitMaterial = null;
	}

	public void Recreate(PostProcessData data, ref PostProcessParams ppParams)
	{
	}

	public void Dispose()
	{
	}

	internal void ReleaseRenderTargets()
	{
	}
}
