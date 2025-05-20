using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets;

internal static class ShorthandApplicator
{
	private static List<TimeValue> s_TransitionDelayList;

	private static List<TimeValue> s_TransitionDurationList;

	private static List<StylePropertyName> s_TransitionPropertyList;

	private static List<EasingFunction> s_TransitionTimingFunctionList;

	public static void ApplyBackgroundPosition(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyBorderColor(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyBorderRadius(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyBorderWidth(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyFlex(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyMargin(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyPadding(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyTransition(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyUnityBackgroundScaleMode(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	public static void ApplyUnityTextOutline(StylePropertyReader reader, ref ComputedStyle computedStyle)
	{
	}

	private static bool CompileFlexShorthand(StylePropertyReader reader, out float grow, out float shrink, out Length basis)
	{
		grow = default(float);
		shrink = default(float);
		basis = default(Length);
		return false;
	}

	private static void CompileBorderRadius(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
	{
		top = default(Length);
		right = default(Length);
		bottom = default(Length);
		left = default(Length);
	}

	private static void CompileBackgroundPosition(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY)
	{
		backgroundPositionX = default(BackgroundPosition);
		backgroundPositionY = default(BackgroundPosition);
	}

	public static void CompileUnityBackgroundScaleMode(StylePropertyReader reader, out BackgroundPosition backgroundPositionX, out BackgroundPosition backgroundPositionY, out BackgroundRepeat backgroundRepeat, out BackgroundSize backgroundSize)
	{
		backgroundPositionX = default(BackgroundPosition);
		backgroundPositionY = default(BackgroundPosition);
		backgroundRepeat = default(BackgroundRepeat);
		backgroundSize = default(BackgroundSize);
	}

	private static void CompileBoxArea(StylePropertyReader reader, out Length top, out Length right, out Length bottom, out Length left)
	{
		top = default(Length);
		right = default(Length);
		bottom = default(Length);
		left = default(Length);
	}

	private static void CompileBoxArea(StylePropertyReader reader, out float top, out float right, out float bottom, out float left)
	{
		top = default(float);
		right = default(float);
		bottom = default(float);
		left = default(float);
	}

	private static void CompileBoxArea(StylePropertyReader reader, out Color top, out Color right, out Color bottom, out Color left)
	{
		top = default(Color);
		right = default(Color);
		bottom = default(Color);
		left = default(Color);
	}

	private static void CompileTextOutline(StylePropertyReader reader, out Color outlineColor, out float outlineWidth)
	{
		outlineColor = default(Color);
		outlineWidth = default(float);
	}

	private static void CompileTransition(StylePropertyReader reader, out List<TimeValue> outDelay, out List<TimeValue> outDuration, out List<StylePropertyName> outProperty, out List<EasingFunction> outTimingFunction)
	{
		outDelay = null;
		outDuration = null;
		outProperty = null;
		outTimingFunction = null;
	}
}
