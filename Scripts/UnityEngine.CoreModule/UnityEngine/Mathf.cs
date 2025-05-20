using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[StructLayout((LayoutKind)0, Size = 1)]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
[NativeHeader("Runtime/Utilities/BitUtility.h")]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/FloatConversion.h")]
public struct Mathf
{
	public static readonly float Epsilon;

	[FreeFunction(IsThreadSafe = true)]
	public static int ClosestPowerOfTwo(int value)
	{
		return 0;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static bool IsPowerOfTwo(int value)
	{
		return false;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static int NextPowerOfTwo(int value)
	{
		return 0;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static float GammaToLinearSpace(float value)
	{
		return 0f;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static float LinearToGammaSpace(float value)
	{
		return 0f;
	}

	[FreeFunction(IsThreadSafe = true)]
	public static Color CorrelatedColorTemperatureToRGB(float kelvin)
	{
		return default(Color);
	}

	[FreeFunction(IsThreadSafe = true)]
	public static ushort FloatToHalf(float val)
	{
		return 0;
	}

	[FreeFunction("PerlinNoise::NoiseNormalized", IsThreadSafe = true)]
	public static float PerlinNoise(float x, float y)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Sin(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Cos(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Tan(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Asin(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Acos(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Atan(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Atan2(float y, float x)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Sqrt(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Abs(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Abs(int value)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Min(float a, float b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Min(params float[] values)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Min(int a, int b)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Min(params int[] values)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Max(float a, float b)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Max(params float[] values)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Max(int a, int b)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Pow(float f, float p)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Exp(float power)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Log(float f, float p)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Log(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Log10(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Ceil(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Floor(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Round(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int CeilToInt(float f)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int FloorToInt(float f)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int RoundToInt(float f)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Sign(float f)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Clamp(float value, float min, float max)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Clamp(int value, int min, int max)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Clamp01(float value)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Lerp(float a, float b, float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float LerpUnclamped(float a, float b, float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float LerpAngle(float a, float b, float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float MoveTowards(float current, float target, float maxDelta)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float MoveTowardsAngle(float current, float target, float maxDelta)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SmoothStep(float from, float to, float t)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Approximately(float a, float b)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromDocs]
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
	{
		return 0f;
	}

	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[ExcludeFromDocs]
	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Repeat(float t, float length)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float PingPong(float t, float length)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float InverseLerp(float a, float b, float value)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float DeltaAngle(float current, float target)
	{
		return 0f;
	}

	internal static float ClampToFloat(double value)
	{
		return 0f;
	}

	internal static int ClampToInt(long value)
	{
		return 0;
	}

	internal static uint ClampToUInt(long value)
	{
		return 0u;
	}

	internal static int GetNumberOfDecimalsForMinimumDifference(double minDifference)
	{
		return 0;
	}

	internal static double RoundBasedOnMinimumDifference(double valueToRound, double minDifference)
	{
		return 0.0;
	}

	internal static double DiscardLeastSignificantDecimal(double v)
	{
		return 0.0;
	}

	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret)
	{
		ret = default(Color);
	}
}
