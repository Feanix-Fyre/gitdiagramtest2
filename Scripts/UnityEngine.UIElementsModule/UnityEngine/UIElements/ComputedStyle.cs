using System;
using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements;

internal struct ComputedStyle
{
	public StyleDataRef<InheritedData> inheritedData;

	public StyleDataRef<LayoutData> layoutData;

	public StyleDataRef<RareData> rareData;

	public StyleDataRef<TransformData> transformData;

	public StyleDataRef<TransitionData> transitionData;

	public StyleDataRef<VisualData> visualData;

	public YogaNode yogaNode;

	public Dictionary<string, StylePropertyValue> customProperties;

	public long matchingRulesHash;

	public float dpiScaling;

	public ComputedTransitionProperty[] computedTransitions;

	public int customPropertiesCount => 0;

	public bool hasTransition => false;

	public Align alignContent => default(Align);

	public Align alignItems => default(Align);

	public Align alignSelf => default(Align);

	public Color backgroundColor => default(Color);

	public Background backgroundImage => default(Background);

	public BackgroundPosition backgroundPositionX => default(BackgroundPosition);

	public BackgroundPosition backgroundPositionY => default(BackgroundPosition);

	public BackgroundRepeat backgroundRepeat => default(BackgroundRepeat);

	public BackgroundSize backgroundSize => default(BackgroundSize);

	public Color borderBottomColor => default(Color);

	public Length borderBottomLeftRadius => default(Length);

	public Length borderBottomRightRadius => default(Length);

	public float borderBottomWidth => 0f;

	public Color borderLeftColor => default(Color);

	public float borderLeftWidth => 0f;

	public Color borderRightColor => default(Color);

	public float borderRightWidth => 0f;

	public Color borderTopColor => default(Color);

	public Length borderTopLeftRadius => default(Length);

	public Length borderTopRightRadius => default(Length);

	public float borderTopWidth => 0f;

	public Length bottom => default(Length);

	public Color color => default(Color);

	public Cursor cursor => default(Cursor);

	public DisplayStyle display => default(DisplayStyle);

	public Length flexBasis => default(Length);

	public FlexDirection flexDirection => default(FlexDirection);

	public float flexGrow => 0f;

	public float flexShrink => 0f;

	public Wrap flexWrap => default(Wrap);

	public Length fontSize => default(Length);

	public Length height => default(Length);

	public Justify justifyContent => default(Justify);

	public Length left => default(Length);

	public Length letterSpacing => default(Length);

	public Length marginBottom => default(Length);

	public Length marginLeft => default(Length);

	public Length marginRight => default(Length);

	public Length marginTop => default(Length);

	public Length maxHeight => default(Length);

	public Length maxWidth => default(Length);

	public Length minHeight => default(Length);

	public Length minWidth => default(Length);

	public float opacity => 0f;

	public OverflowInternal overflow => default(OverflowInternal);

	public Length paddingBottom => default(Length);

	public Length paddingLeft => default(Length);

	public Length paddingRight => default(Length);

	public Length paddingTop => default(Length);

	public Position position => default(Position);

	public Length right => default(Length);

	public Rotate rotate => default(Rotate);

	public Scale scale => default(Scale);

	public TextOverflow textOverflow => default(TextOverflow);

	public TextShadow textShadow => default(TextShadow);

	public Length top => default(Length);

	public TransformOrigin transformOrigin => default(TransformOrigin);

	public List<TimeValue> transitionDelay => null;

	public List<TimeValue> transitionDuration => null;

	public List<StylePropertyName> transitionProperty => null;

	public List<EasingFunction> transitionTimingFunction => null;

	public Translate translate => default(Translate);

	public Color unityBackgroundImageTintColor => default(Color);

	public Font unityFont => null;

	public FontDefinition unityFontDefinition => default(FontDefinition);

	public FontStyle unityFontStyleAndWeight => default(FontStyle);

	public OverflowClipBox unityOverflowClipBox => default(OverflowClipBox);

	public Length unityParagraphSpacing => default(Length);

	public int unitySliceBottom => 0;

	public int unitySliceLeft => 0;

	public int unitySliceRight => 0;

	public float unitySliceScale => 0f;

	public int unitySliceTop => 0;

	public TextAnchor unityTextAlign => default(TextAnchor);

	public Color unityTextOutlineColor => default(Color);

	public float unityTextOutlineWidth => 0f;

	public TextOverflowPosition unityTextOverflowPosition => default(TextOverflowPosition);

	public Visibility visibility => default(Visibility);

	public WhiteSpace whiteSpace => default(WhiteSpace);

	public Length width => default(Length);

	public Length wordSpacing => default(Length);

	public void FinalizeApply(ref ComputedStyle parentStyle)
	{
	}

	public void SyncWithLayout(YogaNode targetNode)
	{
	}

	private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle)
	{
		return false;
	}

	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle)
	{
		return false;
	}

	private void RemoveCustomStyleProperty(StylePropertyReader reader)
	{
	}

	private void ApplyCustomStyleProperty(StylePropertyReader reader)
	{
	}

	private void ApplyAllPropertyInitial()
	{
	}

	private void ResetComputedTransitions()
	{
	}

	public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	public static ComputedStyle Create(ref ComputedStyle parentStyle)
	{
		return default(ComputedStyle);
	}

	public static ComputedStyle CreateInitial()
	{
		return default(ComputedStyle);
	}

	public ComputedStyle Acquire()
	{
		return default(ComputedStyle);
	}

	public void Release()
	{
	}

	public void CopyFrom(ref ComputedStyle other)
	{
	}

	public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle)
	{
	}

	public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle)
	{
	}

	public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle)
	{
	}

	public void ApplyStyleCursor(Cursor cursor)
	{
	}

	public void ApplyStyleTextShadow(TextShadow st)
	{
	}

	public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue)
	{
	}

	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue)
	{
	}

	public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	public void ApplyStyleTransformOrigin(TransformOrigin st)
	{
	}

	public void ApplyStyleTranslate(Translate translateValue)
	{
	}

	public void ApplyStyleRotate(Rotate rotateValue)
	{
	}

	public void ApplyStyleScale(Scale scaleValue)
	{
	}

	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue)
	{
	}

	public void ApplyInitialValue(StylePropertyReader reader)
	{
	}

	public void ApplyInitialValue(StylePropertyId id)
	{
	}

	public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle)
	{
	}

	public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle)
	{
	}

	public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y)
	{
		return default(VersionChangeType);
	}
}
