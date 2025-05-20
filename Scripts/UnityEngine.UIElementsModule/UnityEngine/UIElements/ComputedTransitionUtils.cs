using System;
using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

internal static class ComputedTransitionUtils
{
	private static List<ComputedTransitionProperty> s_ComputedTransitionsBuffer;

	internal static void UpdateComputedTransitions(ref ComputedStyle computedStyle)
	{
	}

	internal static bool HasTransitionProperty(this ref ComputedStyle computedStyle, StylePropertyId id)
	{
		return false;
	}

	internal static bool GetTransitionProperty(this ref ComputedStyle computedStyle, StylePropertyId id, out ComputedTransitionProperty result)
	{
		result = default(ComputedTransitionProperty);
		return false;
	}

	private static ComputedTransitionProperty[] GetOrComputeTransitionPropertyData(ref ComputedStyle computedStyle)
	{
		return null;
	}

	private static int GetTransitionHashCode(ref ComputedStyle cs)
	{
		return 0;
	}

	internal static bool SameTransitionProperty(ref ComputedStyle x, ref ComputedStyle y)
	{
		return false;
	}

	private static bool SameTransitionProperty(List<StylePropertyName> a, List<StylePropertyName> b)
	{
		return false;
	}

	private static bool SameTransitionProperty(List<TimeValue> a, List<TimeValue> b)
	{
		return false;
	}

	private static void ComputeTransitionPropertyData(ref ComputedStyle computedStyle, List<ComputedTransitionProperty> outData)
	{
	}

	private static T GetWrappingTransitionData<T>(List<T> list, int i, T defaultValue)
	{
		return default(T);
	}

	private static int ConvertTransitionTime(TimeValue time)
	{
		return 0;
	}

	private static Func<float, float> ConvertTransitionFunction(EasingMode mode)
	{
		return null;
	}
}
