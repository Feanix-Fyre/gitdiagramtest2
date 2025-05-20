using System.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets;

internal static class InitialStyle
{
	private static ComputedStyle s_InitialStyle;

	public static Align alignContent => default(Align);

	public static Align alignItems => default(Align);

	public static Align alignSelf => default(Align);

	public static Color backgroundColor => default(Color);

	public static Background backgroundImage => default(Background);

	public static BackgroundPosition backgroundPositionX => default(BackgroundPosition);

	public static BackgroundPosition backgroundPositionY => default(BackgroundPosition);

	public static BackgroundRepeat backgroundRepeat => default(BackgroundRepeat);

	public static BackgroundSize backgroundSize => default(BackgroundSize);

	public static Color borderBottomColor => default(Color);

	public static Length borderBottomLeftRadius => default(Length);

	public static Length borderBottomRightRadius => default(Length);

	public static float borderBottomWidth => 0f;

	public static Color borderLeftColor => default(Color);

	public static float borderLeftWidth => 0f;

	public static Color borderRightColor => default(Color);

	public static float borderRightWidth => 0f;

	public static Color borderTopColor => default(Color);

	public static Length borderTopLeftRadius => default(Length);

	public static Length borderTopRightRadius => default(Length);

	public static float borderTopWidth => 0f;

	public static Length bottom => default(Length);

	public static Color color => default(Color);

	public static Cursor cursor => default(Cursor);

	public static DisplayStyle display => default(DisplayStyle);

	public static Length flexBasis => default(Length);

	public static FlexDirection flexDirection => default(FlexDirection);

	public static float flexGrow => 0f;

	public static float flexShrink => 0f;

	public static Wrap flexWrap => default(Wrap);

	public static Length fontSize => default(Length);

	public static Length height => default(Length);

	public static Justify justifyContent => default(Justify);

	public static Length left => default(Length);

	public static Length letterSpacing => default(Length);

	public static Length marginBottom => default(Length);

	public static Length marginLeft => default(Length);

	public static Length marginRight => default(Length);

	public static Length marginTop => default(Length);

	public static Length maxHeight => default(Length);

	public static Length maxWidth => default(Length);

	public static Length minHeight => default(Length);

	public static Length minWidth => default(Length);

	public static float opacity => 0f;

	public static OverflowInternal overflow => default(OverflowInternal);

	public static Length paddingBottom => default(Length);

	public static Length paddingLeft => default(Length);

	public static Length paddingRight => default(Length);

	public static Length paddingTop => default(Length);

	public static Position position => default(Position);

	public static Length right => default(Length);

	public static Rotate rotate => default(Rotate);

	public static Scale scale => default(Scale);

	public static TextOverflow textOverflow => default(TextOverflow);

	public static TextShadow textShadow => default(TextShadow);

	public static Length top => default(Length);

	public static TransformOrigin transformOrigin => default(TransformOrigin);

	public static List<TimeValue> transitionDelay => null;

	public static List<TimeValue> transitionDuration => null;

	public static List<StylePropertyName> transitionProperty => null;

	public static List<EasingFunction> transitionTimingFunction => null;

	public static Translate translate => default(Translate);

	public static Color unityBackgroundImageTintColor => default(Color);

	public static Font unityFont => null;

	public static FontDefinition unityFontDefinition => default(FontDefinition);

	public static FontStyle unityFontStyleAndWeight => default(FontStyle);

	public static OverflowClipBox unityOverflowClipBox => default(OverflowClipBox);

	public static Length unityParagraphSpacing => default(Length);

	public static int unitySliceBottom => 0;

	public static int unitySliceLeft => 0;

	public static int unitySliceRight => 0;

	public static float unitySliceScale => 0f;

	public static int unitySliceTop => 0;

	public static TextAnchor unityTextAlign => default(TextAnchor);

	public static Color unityTextOutlineColor => default(Color);

	public static float unityTextOutlineWidth => 0f;

	public static TextOverflowPosition unityTextOverflowPosition => default(TextOverflowPosition);

	public static Visibility visibility => default(Visibility);

	public static WhiteSpace whiteSpace => default(WhiteSpace);

	public static Length width => default(Length);

	public static Length wordSpacing => default(Length);

	public static ref ComputedStyle Get()
	{
		throw null;
	}

	public static ComputedStyle Acquire()
	{
		return default(ComputedStyle);
	}

	static InitialStyle()
	{
	}
}
