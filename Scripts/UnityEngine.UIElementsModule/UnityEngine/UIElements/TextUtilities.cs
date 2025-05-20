using UnityEngine.TextCore.Text;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

internal static class TextUtilities
{
	internal static Vector2 MeasureVisualElementTextSize(TextElement te, string textToMeasure, float width, VisualElement.MeasureMode widthMode, float height, VisualElement.MeasureMode heightMode)
	{
		return default(Vector2);
	}

	internal static FontAsset GetFontAsset(VisualElement ve)
	{
		return null;
	}

	internal static bool IsFontAssigned(VisualElement ve)
	{
		return false;
	}

	internal static PanelTextSettings GetTextSettingsFrom(VisualElement ve)
	{
		return null;
	}

	internal static float ConvertPixelUnitsToTextCoreRelativeUnits(VisualElement ve, FontAsset fontAsset)
	{
		return 0f;
	}

	internal static TextCoreSettings GetTextCoreSettingsForElement(VisualElement ve)
	{
		return default(TextCoreSettings);
	}
}
