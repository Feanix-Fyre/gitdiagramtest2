using System;
using System.Runtime.InteropServices;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

internal class LightCookieManager : IDisposable
{
	private static class ShaderProperty
	{
		public static readonly int mainLightTexture;

		public static readonly int mainLightWorldToLight;

		public static readonly int mainLightCookieTextureFormat;

		public static readonly int additionalLightsCookieAtlasTexture;

		public static readonly int additionalLightsCookieAtlasTextureFormat;

		public static readonly int additionalLightsCookieEnableBits;

		public static readonly int additionalLightsCookieAtlasUVRectBuffer;

		public static readonly int additionalLightsCookieAtlasUVRects;

		public static readonly int additionalLightsWorldToLightBuffer;

		public static readonly int additionalLightsLightTypeBuffer;

		public static readonly int additionalLightsWorldToLights;

		public static readonly int additionalLightsLightTypes;
	}

	private enum LightCookieShaderFormat
	{
		None = -1,
		RGB = 0,
		Alpha = 1,
		Red = 2
	}

	public struct Settings
	{
		public struct AtlasSettings
		{
			public Vector2Int resolution;

			public GraphicsFormat format;

			public bool useMips;

			public bool isPow2 => false;

			public bool isSquare => false;
		}

		public AtlasSettings atlas;

		public int maxAdditionalLights;

		public float cubeOctahedralSizeScale;

		public bool useStructuredBuffer;

		public static Settings Create()
		{
			return default(Settings);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct Sorting
	{
		public static void QuickSort<T>(T[] data, Func<T, T, int> compare)
		{
		}

		public static void QuickSort<T>(T[] data, int start, int end, Func<T, T, int> compare)
		{
		}

		private static T Median3Pivot<T>(T[] data, int start, int pivot, int end, Func<T, T, int> compare)
		{
			return default(T);
		}

		private static int Partition<T>(T[] data, int start, int end, Func<T, T, int> compare)
		{
			return 0;
		}

		public static void InsertionSort<T>(T[] data, int start, int end, Func<T, T, int> compare)
		{
		}
	}

	private struct LightCookieMapping
	{
		public ushort visibleLightIndex;

		public ushort lightBufferIndex;

		public Light light;

		public static Func<LightCookieMapping, LightCookieMapping, int> s_CompareByCookieSize;

		public static Func<LightCookieMapping, LightCookieMapping, int> s_CompareByBufferIndex;
	}

	private readonly struct WorkSlice<T>
	{
		private readonly T[] m_Data;

		private readonly int m_Start;

		private readonly int m_Length;

		public T this[int index]
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public int length => 0;

		public int capacity => 0;

		public WorkSlice(T[] src, int srcLen = -1)
		{
			m_Data = null;
			m_Start = 0;
			m_Length = 0;
		}

		public WorkSlice(T[] src, int srcStart, int srcLen = -1)
		{
			m_Data = null;
			m_Start = 0;
			m_Length = 0;
		}

		public void Sort(Func<T, T, int> compare)
		{
		}
	}

	private class WorkMemory
	{
		public LightCookieMapping[] lightMappings;

		public Vector4[] uvRects;

		public void Resize(int size)
		{
		}
	}

	private struct ShaderBitArray
	{
		private const int k_BitsPerElement = 32;

		private const int k_ElementShift = 5;

		private const int k_ElementMask = 31;

		private float[] m_Data;

		public int elemLength => 0;

		public int bitCapacity => 0;

		public float[] data => null;

		public bool this[int index]
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Resize(int bitCount)
		{
		}

		public void Clear()
		{
		}

		private void GetElementIndexAndBitOffset(int index, out int elemIndex, out int bitOffset)
		{
			elemIndex = default(int);
			bitOffset = default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}

	private class LightCookieShaderData : IDisposable
	{
		private int m_Size;

		private bool m_UseStructuredBuffer;

		private Matrix4x4[] m_WorldToLightCpuData;

		private Vector4[] m_AtlasUVRectCpuData;

		private float[] m_LightTypeCpuData;

		private ShaderBitArray m_CookieEnableBitsCpuData;

		private ComputeBuffer m_WorldToLightBuffer;

		private ComputeBuffer m_AtlasUVRectBuffer;

		private ComputeBuffer m_LightTypeBuffer;

		public Matrix4x4[] worldToLights => null;

		public ShaderBitArray cookieEnableBits => default(ShaderBitArray);

		public Vector4[] atlasUVRects => null;

		public float[] lightTypes => null;

		public bool isUploaded { get; set; }

		public LightCookieShaderData(int size, bool useStructuredBuffer)
		{
		}

		public void Dispose()
		{
		}

		public void Resize(int size)
		{
		}

		public void Upload(CommandBuffer cmd)
		{
		}

		public void Clear(CommandBuffer cmd)
		{
		}
	}

	private static readonly Matrix4x4 s_DirLightProj;

	private Texture2DAtlas m_AdditionalLightsCookieAtlas;

	private LightCookieShaderData m_AdditionalLightsCookieShaderData;

	private readonly Settings m_Settings;

	private WorkMemory m_WorkMem;

	private int[] m_VisibleLightIndexToShaderDataIndex;

	private const int k_MaxCookieSizeDivisor = 16;

	private int m_CookieSizeDivisor;

	private uint m_PrevCookieRequestPixelCount;

	private int m_PrevWarnFrame;

	internal bool IsKeywordLightCookieEnabled { get; private set; }

	public LightCookieManager(ref Settings settings)
	{
	}

	private void InitAdditionalLights(int size)
	{
	}

	public bool isInitialized()
	{
		return false;
	}

	public void Dispose()
	{
	}

	public int GetLightCookieShaderDataIndex(int visibleLightIndex)
	{
		return 0;
	}

	public void Setup(ScriptableRenderContext ctx, CommandBuffer cmd, ref LightData lightData)
	{
	}

	private bool SetupMainLight(CommandBuffer cmd, ref VisibleLight visibleMainLight)
	{
		return false;
	}

	private LightCookieShaderFormat GetLightCookieShaderFormat(GraphicsFormat cookieFormat)
	{
		return default(LightCookieShaderFormat);
	}

	private void GetLightUVScaleOffset(ref UniversalAdditionalLightData additionalLightData, ref Matrix4x4 uvTransform)
	{
	}

	private bool SetupAdditionalLights(CommandBuffer cmd, ref LightData lightData)
	{
		return false;
	}

	private int FilterAndValidateAdditionalLights(ref LightData lightData, LightCookieMapping[] validLightMappings)
	{
		return 0;
	}

	private int UpdateAdditionalLightsAtlas(CommandBuffer cmd, ref WorkSlice<LightCookieMapping> validLightMappings, Vector4[] textureAtlasUVRects)
	{
		return 0;
	}

	private int FetchUVRects(CommandBuffer cmd, ref WorkSlice<LightCookieMapping> validLightMappings, Vector4[] textureAtlasUVRects, int cookieSizeDivisor)
	{
		return 0;
	}

	private uint ComputeCookieRequestPixelCount(ref WorkSlice<LightCookieMapping> validLightMappings)
	{
		return 0u;
	}

	private int ApproximateCookieSizeDivisor(float requestAtlasRatio)
	{
		return 0;
	}

	private Vector4 Fetch2D(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1)
	{
		return default(Vector4);
	}

	private Vector4 FetchCube(CommandBuffer cmd, Texture cookie, int cookieSizeDivisor = 1)
	{
		return default(Vector4);
	}

	private int ComputeOctahedralCookieSize(Texture cookie)
	{
		return 0;
	}

	private void AdjustUVRect(ref Vector4 uvScaleOffset, Texture cookie, ref Vector2 cookieSize)
	{
	}

	private void ShrinkUVRect(ref Vector4 uvScaleOffset, float amountPixels, ref Vector2 cookieSize)
	{
	}

	private void UploadAdditionalLights(CommandBuffer cmd, ref LightData lightData, ref WorkSlice<LightCookieMapping> validLightMappings, ref WorkSlice<Vector4> validUvRects)
	{
	}
}
