using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
public sealed class TemporalAntialiasing
{
	private enum Pass
	{
		SolverDilate = 0,
		SolverNoDilate = 1
	}

	[Range(0.1f, 1f)]
	[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
	public float jitterSpread;

	[Range(0f, 3f)]
	[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
	public float sharpness;

	[Range(0f, 0.99f)]
	[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
	public float stationaryBlending;

	[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
	[Range(0f, 0.99f)]
	public float motionBlending;

	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc;

	private readonly RenderTargetIdentifier[] m_Mrt;

	private bool m_ResetHistory;

	private const int k_SampleCount = 8;

	private const int k_NumEyes = 2;

	private const int k_NumHistoryTextures = 2;

	private readonly RenderTexture[][] m_HistoryTextures;

	private readonly int[] m_HistoryPingPong;

	public Vector2 jitter { get; private set; }

	public int sampleIndex { get; private set; }

	public bool IsSupported()
	{
		return false;
	}

	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	internal void ResetHistory()
	{
	}

	private Vector2 GenerateRandomOffset()
	{
		return default(Vector2);
	}

	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera)
	{
		return default(Matrix4x4);
	}

	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context)
	{
	}

	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context)
	{
	}

	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context)
	{
	}

	private RenderTexture CheckHistory(int id, PostProcessRenderContext context)
	{
		return null;
	}

	internal void Render(PostProcessRenderContext context)
	{
	}

	internal void Release()
	{
	}
}
