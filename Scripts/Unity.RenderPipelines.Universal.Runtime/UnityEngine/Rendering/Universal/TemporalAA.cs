using System;
using UnityEngine.Experimental.Rendering.RenderGraphModule;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.Universal;

public static class TemporalAA
{
	internal static class ShaderConstants
	{
		public static readonly int _TaaAccumulationTex;

		public static readonly int _TaaMotionVectorTex;

		public static readonly int _TaaFilterWeights;

		public static readonly int _TaaFrameInfluence;

		public static readonly int _TaaVarianceClampScale;

		public static readonly int _CameraDepthTexture;
	}

	internal static class ShaderKeywords
	{
		public static readonly string TAA_LOW_PRECISION_SOURCE;
	}

	[Serializable]
	public struct Settings
	{
		[SerializeField]
		[FormerlySerializedAs("quality")]
		internal TemporalAAQuality m_Quality;

		[FormerlySerializedAs("frameInfluence")]
		[SerializeField]
		internal float m_FrameInfluence;

		[FormerlySerializedAs("jitterScale")]
		[SerializeField]
		internal float m_JitterScale;

		[FormerlySerializedAs("mipBias")]
		[SerializeField]
		internal float m_MipBias;

		[FormerlySerializedAs("varianceClampScale")]
		[SerializeField]
		internal float m_VarianceClampScale;

		[FormerlySerializedAs("contrastAdaptiveSharpening")]
		[SerializeField]
		internal float m_ContrastAdaptiveSharpening;

		[NonSerialized]
		internal int resetHistoryFrames;

		[NonSerialized]
		internal int jitterFrameCountOffset;

		public TemporalAAQuality quality
		{
			get
			{
				return default(TemporalAAQuality);
			}
			set
			{
			}
		}

		public float baseBlendFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float jitterScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mipBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float varianceClampScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float contrastAdaptiveSharpening
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static Settings Create()
		{
			return default(Settings);
		}
	}

	private class TaaPassData
	{
		internal TextureHandle dstTex;

		internal TextureHandle srcColorTex;

		internal TextureHandle srcDepthTex;

		internal TextureHandle srcMotionVectorTex;

		internal TextureHandle srcTaaAccumTex;

		internal Material material;

		internal int passIndex;

		internal float taaFrameInfluence;

		internal float taaVarianceClampScale;

		internal float[] taaFilterWeights;

		internal bool taaLowPrecisionSource;
	}

	private static readonly Vector2[] taaFilterOffsets;

	private static readonly float[] taaFilterWeights;

	internal static Matrix4x4 CalculateJitterMatrix(ref CameraData cameraData)
	{
		return default(Matrix4x4);
	}

	internal static Vector2 CalculateJitter(int frameIndex)
	{
		return default(Vector2);
	}

	internal static float[] CalculateFilterWeights(float jitterScale)
	{
		return null;
	}

	internal static string ValidateAndWarn(ref CameraData cameraData)
	{
		return null;
	}

	internal static void ExecutePass(CommandBuffer cmd, Material taaMaterial, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderTexture motionVectors)
	{
	}

	internal static void Render(RenderGraph renderGraph, Material taaMaterial, ref CameraData cameraData, ref TextureHandle srcColor, ref TextureHandle srcDepth, ref TextureHandle srcMotionVectors, ref TextureHandle dstColor)
	{
	}
}
