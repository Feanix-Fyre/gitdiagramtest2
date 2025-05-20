using System;

namespace UnityEngine.Rendering;

public static class HDROutputUtils
{
	[Flags]
	public enum Operation
	{
		None = 0,
		ColorConversion = 1,
		ColorEncoding = 2
	}

	public struct HDRDisplayInformation
	{
		public int maxFullFrameToneMapLuminance;

		public int maxToneMapLuminance;

		public int minToneMapLuminance;

		public float paperWhiteNits;

		public HDRDisplayInformation(int maxFullFrameToneMapLuminance, int maxToneMapLuminance, int minToneMapLuminance, float hdrPaperWhiteNits)
		{
			this.maxFullFrameToneMapLuminance = 0;
			this.maxToneMapLuminance = 0;
			this.minToneMapLuminance = 0;
			paperWhiteNits = 0f;
		}
	}

	public static class ShaderKeywords
	{
		public const string HDR_COLORSPACE_CONVERSION = "HDR_COLORSPACE_CONVERSION";

		public const string HDR_ENCODING = "HDR_ENCODING";

		public const string HDR_COLORSPACE_CONVERSION_AND_ENCODING = "HDR_COLORSPACE_CONVERSION_AND_ENCODING";

		public const string HDR_INPUT = "HDR_INPUT";

		internal static readonly ShaderKeyword HDRColorSpaceConversion;

		internal static readonly ShaderKeyword HDREncoding;

		internal static readonly ShaderKeyword HDRColorSpaceConversionAndEncoding;

		internal static readonly ShaderKeyword HDRInput;
	}

	private static class ShaderPropertyId
	{
		public static readonly int hdrColorSpace;

		public static readonly int hdrEncoding;
	}

	public static bool GetColorSpaceForGamut(ColorGamut gamut, out int colorspace)
	{
		colorspace = default(int);
		return false;
	}

	public static bool GetColorEncodingForGamut(ColorGamut gamut, out int encoding)
	{
		encoding = default(int);
		return false;
	}

	public static void ConfigureHDROutput(Material material, ColorGamut gamut, Operation operations)
	{
	}

	public static void ConfigureHDROutput(MaterialPropertyBlock properties, ColorGamut gamut)
	{
	}

	public static void ConfigureHDROutput(Material material, Operation operations)
	{
	}

	public static void ConfigureHDROutput(ComputeShader computeShader, ColorGamut gamut, Operation operations)
	{
	}

	public static bool IsShaderVariantValid(ShaderKeywordSet shaderKeywordSet, bool isHDREnabled)
	{
		return false;
	}
}
