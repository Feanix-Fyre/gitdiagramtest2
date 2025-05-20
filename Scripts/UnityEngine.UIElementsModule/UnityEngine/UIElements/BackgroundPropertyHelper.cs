namespace UnityEngine.UIElements;

internal static class BackgroundPropertyHelper
{
	public static BackgroundPosition ConvertScaleModeToBackgroundPosition(ScaleMode scaleMode = ScaleMode.StretchToFill)
	{
		return default(BackgroundPosition);
	}

	public static BackgroundRepeat ConvertScaleModeToBackgroundRepeat(ScaleMode scaleMode = ScaleMode.StretchToFill)
	{
		return default(BackgroundRepeat);
	}

	public static BackgroundSize ConvertScaleModeToBackgroundSize(ScaleMode scaleMode = ScaleMode.StretchToFill)
	{
		return default(BackgroundSize);
	}

	public static ScaleMode ResolveUnityBackgroundScaleMode(BackgroundPosition backgroundPositionX, BackgroundPosition backgroundPositionY, BackgroundRepeat backgroundRepeat, BackgroundSize backgroundSize, out bool valid)
	{
		valid = default(bool);
		return default(ScaleMode);
	}
}
