using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine;

[MovedFrom("UnityEditor")]
internal class NumericFieldDraggerUtility
{
	private static bool s_UseYSign;

	internal static float Acceleration(bool shiftPressed, bool altPressed)
	{
		return 0f;
	}

	internal static float NiceDelta(Vector2 deviceDelta, float acceleration)
	{
		return 0f;
	}

	internal static double CalculateFloatDragSensitivity(double value)
	{
		return 0.0;
	}

	internal static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue)
	{
		return 0.0;
	}

	internal static long CalculateIntDragSensitivity(long value)
	{
		return 0L;
	}

	internal static ulong CalculateIntDragSensitivity(ulong value)
	{
		return 0uL;
	}

	private static double CalculateIntDragSensitivity(double value)
	{
		return 0.0;
	}

	internal static long CalculateIntDragSensitivity(long value, long minValue, long maxValue)
	{
		return 0L;
	}
}
