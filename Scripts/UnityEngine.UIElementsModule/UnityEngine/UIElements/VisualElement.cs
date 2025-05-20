using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.UIR;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements;

public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler
{
	public class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits>
	{
	}

	public class UxmlTraits : UnityEngine.UIElements.UxmlTraits
	{
		protected UxmlStringAttributeDescription m_Name;

		private UxmlStringAttributeDescription m_ViewDataKey;

		protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode;

		private UxmlStringAttributeDescription m_Tooltip;

		private UxmlEnumAttributeDescription<UsageHints> m_UsageHints;

		private UxmlIntAttributeDescription m_TabIndex;

		private UxmlStringAttributeDescription m_Class;

		private UxmlStringAttributeDescription m_ContentContainer;

		private UxmlStringAttributeDescription m_Style;

		protected UxmlIntAttributeDescription focusIndex { get; }

		protected UxmlBoolAttributeDescription focusable { get; }

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public enum MeasureMode
	{
		Undefined = 0,
		Exactly = 1,
		AtMost = 2
	}

	internal enum RenderTargetMode
	{
		None = 0,
		NoColorConversion = 1,
		LinearToGamma = 2,
		GammaToLinear = 3
	}

	public struct Hierarchy
	{
		private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation";

		private readonly VisualElement m_Owner;

		public VisualElement parent => null;

		internal List<VisualElement> children => null;

		public int childCount => 0;

		public VisualElement this[int key] => null;

		internal Hierarchy(VisualElement element)
		{
			m_Owner = null;
		}

		public void Add(VisualElement child)
		{
		}

		public void Insert(int index, VisualElement child)
		{
		}

		public void Remove(VisualElement child)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Clear()
		{
		}

		internal void BringToFront(VisualElement child)
		{
		}

		internal void SendToBack(VisualElement child)
		{
		}

		internal void PlaceBehind(VisualElement child, VisualElement over)
		{
		}

		private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex)
		{
		}

		public int IndexOf(VisualElement element)
		{
			return 0;
		}

		public VisualElement ElementAt(int index)
		{
			return null;
		}

		public IEnumerable<VisualElement> Children()
		{
			return null;
		}

		private void SetParent(VisualElement value)
		{
		}

		private void PutChildAtIndex(VisualElement child, int index)
		{
		}

		private void RemoveChildAtIndex(int index)
		{
		}

		private void ReleaseChildList()
		{
		}

		public bool Equals(Hierarchy other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(Hierarchy x, Hierarchy y)
		{
			return false;
		}
	}

	private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem, IVisualElementPanelActivatable
	{
		public bool isScheduled;

		private VisualElementPanelActivator m_Activator;

		public VisualElement element { get; private set; }

		protected BaseVisualElementScheduledItem(VisualElement handler)
		{
		}

		public IVisualElementScheduledItem StartingIn(long delayMs)
		{
			return null;
		}

		public IVisualElementScheduledItem Every(long intervalMs)
		{
			return null;
		}

		internal override void OnItemUnscheduled()
		{
		}

		public void Resume()
		{
		}

		public void Pause()
		{
		}

		public void ExecuteLater(long delayMs)
		{
		}

		public void OnPanelActivate()
		{
		}

		public void OnPanelDeactivate()
		{
		}

		public bool CanBeActivated()
		{
			return false;
		}
	}

	private abstract class VisualElementScheduledItem<ActionType> : BaseVisualElementScheduledItem
	{
		public ActionType updateEvent;

		public VisualElementScheduledItem(VisualElement handler, ActionType upEvent)
			: base(null)
		{
		}
	}

	private class TimerStateScheduledItem : VisualElementScheduledItem<Action<TimerState>>
	{
		public TimerStateScheduledItem(VisualElement handler, Action<TimerState> updateEvent)
			: base((VisualElement)null, (Action<TimerState>)default(_00210))
		{
		}

		public override void PerformTimerUpdate(TimerState state)
		{
		}
	}

	private class SimpleScheduledItem : VisualElementScheduledItem<Action>
	{
		public SimpleScheduledItem(VisualElement handler, Action updateEvent)
			: base((VisualElement)null, (Action)default(_00210))
		{
		}

		public override void PerformTimerUpdate(TimerState state)
		{
		}
	}

	internal class CustomStyleAccess : ICustomStyle
	{
		private Dictionary<string, StylePropertyValue> m_CustomProperties;

		private float m_DpiScaling;

		public void SetContext(Dictionary<string, StylePropertyValue> customProperties, float dpiScaling)
		{
		}

		public bool TryGetValue(CustomStyleProperty<float> property, out float value)
		{
			value = default(float);
			return false;
		}

		public bool TryGetValue(CustomStyleProperty<int> property, out int value)
		{
			value = default(int);
			return false;
		}

		public bool TryGetValue(CustomStyleProperty<Color> property, out Color value)
		{
			value = default(Color);
			return false;
		}

		public bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value)
		{
			value = null;
			return false;
		}

		public bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value)
		{
			value = null;
			return false;
		}

		public bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value)
		{
			value = null;
			return false;
		}

		public bool TryGetValue(CustomStyleProperty<string> property, out string value)
		{
			value = null;
			return false;
		}

		private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp)
		{
			customProp = default(StylePropertyValue);
			return false;
		}

		private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp)
		{
		}
	}

	internal class TypeData
	{
		private string m_FullTypeName;

		private string m_TypeName;

		private string m_TypeNamespace;

		public Type type { get; }

		public string fullTypeName => null;

		public string typeName => null;

		public string typeNamespace => null;

		public TypeData(Type type)
		{
		}
	}

	private static uint s_NextId;

	private static List<string> s_EmptyClassList;

	internal static readonly PropertyName userDataPropertyKey;

	public static readonly string disabledUssClassName;

	private string m_Name;

	private List<string> m_ClassList;

	private List<KeyValuePair<PropertyName, object>> m_PropertyBag;

	internal VisualElementFlags m_Flags;

	private string m_ViewDataKey;

	private RenderHints m_RenderHints;

	internal Rect lastLayout;

	internal Rect lastPseudoPadding;

	internal RenderChainVEData renderChainData;

	private Rect m_Layout;

	private Rect m_BoundingBox;

	private const VisualElementFlags worldBoundingBoxDirtyDependencies = VisualElementFlags.WorldTransformDirty | VisualElementFlags.BoundingBoxDirty | VisualElementFlags.WorldBoundingBoxDirty;

	private Rect m_WorldBoundingBox;

	private const VisualElementFlags worldTransformInverseDirtyDependencies = VisualElementFlags.WorldTransformDirty | VisualElementFlags.WorldTransformInverseDirty;

	private Matrix4x4 m_WorldTransformCache;

	private Matrix4x4 m_WorldTransformInverseCache;

	private Rect m_WorldClip;

	private Rect m_WorldClipMinusGroup;

	private bool m_WorldClipIsInfinite;

	internal static readonly Rect s_InfiniteRect;

	internal PseudoStates triggerPseudoMask;

	internal PseudoStates dependencyPseudoMask;

	private PseudoStates m_PseudoStates;

	private PickingMode m_PickingMode;

	internal ComputedStyle m_Style;

	internal StyleVariableContext variableContext;

	internal int inheritedStylesHash;

	internal readonly uint controlid;

	internal int imguiContainerDescendantCount;

	private LanguageDirection m_LanguageDirection;

	private LanguageDirection m_LocalLanguageDirection;

	private static readonly ProfilerMarker k_GenerateVisualContentMarker;

	private RenderTargetMode m_SubRenderTargetMode;

	private static Material s_runtimeMaterial;

	private Material m_defaultMaterial;

	private List<IValueAnimationUpdate> m_RunningAnimations;

	private static uint s_NextParentVersion;

	private uint m_NextParentCachedVersion;

	private uint m_NextParentRequiredVersion;

	private VisualElement m_CachedNextParentWithEventCallback;

	private int m_EventCallbackCategories;

	private int m_CachedEventCallbackParentCategories;

	private readonly int m_DefaultActionEventCategories;

	private readonly int m_DefaultActionAtTargetEventCategories;

	internal const string k_RootVisualContainerName = "rootVisualContainer";

	private VisualElement m_PhysicalParent;

	private VisualElement m_LogicalParent;

	private static readonly List<VisualElement> s_EmptyList;

	private List<VisualElement> m_Children;

	private VisualTreeAsset m_VisualTreeAssetSource;

	internal static CustomStyleAccess s_CustomStyleAccess;

	internal InlineStyleAccess inlineStyleAccess;

	internal List<StyleSheet> styleSheetList;

	private static readonly Regex s_InternalStyleSheetPath;

	internal static readonly PropertyName tooltipPropertyKey;

	private static readonly Dictionary<Type, TypeData> s_TypeData;

	private TypeData m_TypeData;

	public IResolvedStyle resolvedStyle => null;

	Color IResolvedStyle.backgroundColor => default(Color);

	Color IResolvedStyle.borderBottomColor => default(Color);

	float IResolvedStyle.borderBottomLeftRadius => 0f;

	float IResolvedStyle.borderBottomRightRadius => 0f;

	float IResolvedStyle.borderBottomWidth => 0f;

	Color IResolvedStyle.borderLeftColor => default(Color);

	float IResolvedStyle.borderLeftWidth => 0f;

	Color IResolvedStyle.borderRightColor => default(Color);

	float IResolvedStyle.borderRightWidth => 0f;

	Color IResolvedStyle.borderTopColor => default(Color);

	float IResolvedStyle.borderTopLeftRadius => 0f;

	float IResolvedStyle.borderTopRightRadius => 0f;

	float IResolvedStyle.borderTopWidth => 0f;

	float IResolvedStyle.bottom => 0f;

	Color IResolvedStyle.color => default(Color);

	DisplayStyle IResolvedStyle.display => default(DisplayStyle);

	FlexDirection IResolvedStyle.flexDirection => default(FlexDirection);

	float IResolvedStyle.flexGrow => 0f;

	float IResolvedStyle.flexShrink => 0f;

	float IResolvedStyle.height => 0f;

	float IResolvedStyle.left => 0f;

	float IResolvedStyle.marginBottom => 0f;

	float IResolvedStyle.marginLeft => 0f;

	float IResolvedStyle.marginRight => 0f;

	float IResolvedStyle.marginTop => 0f;

	StyleFloat IResolvedStyle.minHeight => default(StyleFloat);

	StyleFloat IResolvedStyle.minWidth => default(StyleFloat);

	float IResolvedStyle.opacity => 0f;

	float IResolvedStyle.paddingBottom => 0f;

	float IResolvedStyle.paddingLeft => 0f;

	float IResolvedStyle.paddingRight => 0f;

	float IResolvedStyle.paddingTop => 0f;

	float IResolvedStyle.right => 0f;

	Scale IResolvedStyle.scale => default(Scale);

	float IResolvedStyle.top => 0f;

	Vector3 IResolvedStyle.transformOrigin => default(Vector3);

	Vector3 IResolvedStyle.translate => default(Vector3);

	Color IResolvedStyle.unityBackgroundImageTintColor => default(Color);

	int IResolvedStyle.unitySliceLeft => 0;

	int IResolvedStyle.unitySliceRight => 0;

	float IResolvedStyle.unitySliceScale => 0f;

	Color IResolvedStyle.unityTextOutlineColor => default(Color);

	float IResolvedStyle.unityTextOutlineWidth => 0f;

	Visibility IResolvedStyle.visibility => default(Visibility);

	float IResolvedStyle.width => 0f;

	internal bool hasRunningAnimations => false;

	internal bool hasCompletedAnimations => false;

	int IStylePropertyAnimations.runningAnimationCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	int IStylePropertyAnimations.completedAnimationCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	internal IStylePropertyAnimations styleAnimation => null;

	internal bool isCompositeRoot
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isHierarchyDisplayed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string viewDataKey
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal bool enableViewDataPersistence
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public object userData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override bool canGrabFocus => false;

	public override FocusController focusController => null;

	public UsageHints usageHints
	{
		get
		{
			return default(UsageHints);
		}
		set
		{
		}
	}

	internal RenderHints renderHints
	{
		get
		{
			return default(RenderHints);
		}
		set
		{
		}
	}

	public ITransform transform => null;

	Vector3 ITransform.position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	Vector3 ITransform.scale => default(Vector3);

	internal bool isLayoutManual
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	internal float scaledPixelsPerPoint => 0f;

	public Rect layout
	{
		get
		{
			return default(Rect);
		}
		internal set
		{
		}
	}

	public Rect contentRect => default(Rect);

	protected Rect paddingRect => default(Rect);

	internal bool isBoundingBoxDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isWorldBoundingBoxDirty
	{
		set
		{
		}
	}

	internal bool isWorldBoundingBoxOrDependenciesDirty => false;

	internal Rect boundingBox => default(Rect);

	internal Rect worldBoundingBox => default(Rect);

	private Rect boundingBoxInParentSpace => default(Rect);

	public Rect worldBound => default(Rect);

	public Rect localBound => default(Rect);

	internal Rect rect => default(Rect);

	internal bool isWorldTransformDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isWorldTransformInverseDirty
	{
		set
		{
		}
	}

	internal bool isWorldTransformInverseOrDependenciesDirty => false;

	public Matrix4x4 worldTransform => default(Matrix4x4);

	internal ref Matrix4x4 worldTransformRef
	{
		get
		{
			throw null;
		}
	}

	internal ref Matrix4x4 worldTransformInverse
	{
		get
		{
			throw null;
		}
	}

	internal bool isWorldClipDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal Rect worldClip => default(Rect);

	internal Rect worldClipMinusGroup => default(Rect);

	internal bool worldClipIsInfinite => false;

	internal PseudoStates pseudoStates
	{
		get
		{
			return default(PseudoStates);
		}
		set
		{
		}
	}

	internal int containedPointerIds { get; private set; }

	public PickingMode pickingMode
	{
		get
		{
			return default(PickingMode);
		}
		set
		{
		}
	}

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal List<string> classList => null;

	internal string fullTypeName => null;

	internal string typeName => null;

	internal YogaNode yogaNode { get; private set; }

	internal ref ComputedStyle computedStyle
	{
		get
		{
			throw null;
		}
	}

	internal bool hasInlineStyle => false;

	internal bool styleInitialized
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool isParentEnabledInHierarchy => false;

	public bool enabledInHierarchy => false;

	public bool enabledSelf { get; private set; }

	public LanguageDirection languageDirection => default(LanguageDirection);

	internal LanguageDirection localLanguageDirection
	{
		get
		{
			return default(LanguageDirection);
		}
		set
		{
		}
	}

	public bool visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Action<MeshGenerationContext> generateVisualContent { get; set; }

	internal bool requireMeasureFunction
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal RenderTargetMode subRenderTargetMode => default(RenderTargetMode);

	internal Material defaultMaterial => null;

	internal VisualElement nextParentWithEventCallback => null;

	internal int eventCallbackCategories
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int eventCallbackParentCategories => 0;

	internal bool isEventCallbackParentCategoriesDirty
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public IExperimentalFeatures experimental => null;

	ITransitionAnimations IExperimentalFeatures.animation => null;

	public Hierarchy hierarchy { get; private set; }

	internal bool isRootVisualContainer { get; set; }

	internal bool disableClipping
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public VisualElement parent => null;

	internal BaseVisualElementPanel elementPanel { get; private set; }

	public IPanel panel => null;

	public virtual VisualElement contentContainer => null;

	internal VisualTreeAsset visualTreeAssetSource
	{
		set
		{
		}
	}

	public VisualElement this[int key] => null;

	public int childCount => 0;

	private Vector3 positionWithLayout => default(Vector3);

	internal bool hasDefaultRotationAndScale
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return false;
		}
	}

	public IVisualElementScheduler schedule => null;

	public IStyle style => null;

	public ICustomStyle customStyle => null;

	public VisualElementStyleSheetSet styleSheets => default(VisualElementStyleSheetSet);

	public string tooltip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private TypeData typeData => null;

	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem()
	{
		return null;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	bool IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return false;
	}

	void IStylePropertyAnimations.CancelAnimation(StylePropertyId id)
	{
	}

	void IStylePropertyAnimations.CancelAllAnimations()
	{
	}

	void IStylePropertyAnimations.UpdateAnimation(StylePropertyId id)
	{
	}

	void IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds)
	{
	}

	internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0)
	{
		return false;
	}

	internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to)
	{
		return false;
	}

	internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to)
	{
		return false;
	}

	internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to)
	{
		return false;
	}

	private float? GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0)
	{
		return null;
	}

	internal void MarkRenderHintsClean()
	{
	}

	internal void ClearManualLayout()
	{
	}

	internal void UpdateBoundingBox()
	{
	}

	internal void UpdateWorldBoundingBox()
	{
	}

	internal void UpdateWorldTransform()
	{
	}

	internal void UpdateWorldTransformInverse()
	{
	}

	internal void EnsureWorldTransformAndClipUpToDate()
	{
	}

	private void UpdateWorldClip()
	{
	}

	private Rect CombineClipRects(Rect rect, Rect parentRect)
	{
		return default(Rect);
	}

	private Rect SubstractBorderPadding(Rect worldRect)
	{
		return default(Rect);
	}

	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat)
	{
		return default(Rect);
	}

	private void UpdateHoverPseudoState()
	{
	}

	private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement)
	{
		return false;
	}

	private void ChangeIMGUIContainerCount(int delta)
	{
	}

	[EventInterest(new Type[]
	{
		typeof(MouseOverEvent),
		typeof(MouseOutEvent),
		typeof(MouseCaptureOutEvent),
		typeof(PointerEnterEvent),
		typeof(PointerLeaveEvent),
		typeof(PointerCaptureEvent),
		typeof(PointerCaptureOutEvent),
		typeof(BlurEvent),
		typeof(FocusEvent),
		typeof(TooltipEvent)
	})]
	protected override void ExecuteDefaultAction(EventBase evt)
	{
	}

	internal virtual Rect GetTooltipRect()
	{
		return default(Rect);
	}

	private void SetTooltip(TooltipEvent e)
	{
	}

	public sealed override void Focus()
	{
	}

	internal void SetPanel(BaseVisualElementPanel p)
	{
	}

	private void WillChangePanel(BaseVisualElementPanel destinationPanel)
	{
	}

	private void HasChangedPanel(BaseVisualElementPanel prevPanel)
	{
	}

	public sealed override void SendEvent(EventBase e)
	{
	}

	internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode)
	{
	}

	internal void IncrementVersion(VersionChangeType changeType)
	{
	}

	internal void InvokeHierarchyChanged(HierarchyChangeType changeType)
	{
	}

	private bool SetEnabledFromHierarchyPrivate(bool state)
	{
		return false;
	}

	public void SetEnabled(bool value)
	{
	}

	private void PropagateEnabledToChildren(bool value)
	{
	}

	public void MarkDirtyRepaint()
	{
	}

	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc)
	{
	}

	internal void GetFullHierarchicalViewDataKey(StringBuilder key)
	{
	}

	internal string GetFullHierarchicalViewDataKey()
	{
		return null;
	}

	internal T GetOrCreateViewData<T>(object existing, string key) where T : class, new()
	{
		return null;
	}

	internal void OverwriteFromViewData(object obj, string key)
	{
	}

	internal void SaveViewData()
	{
	}

	internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState)
	{
		return false;
	}

	internal void OnViewDataReady(bool enablePersistence)
	{
	}

	internal virtual void OnViewDataReady()
	{
	}

	public virtual bool ContainsPoint(Vector2 localPoint)
	{
		return false;
	}

	private void AssignMeasureFunction()
	{
	}

	private void RemoveMeasureFunction()
	{
	}

	protected internal virtual Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
	{
		return default(YogaSize);
	}

	private void FinalizeLayout()
	{
	}

	internal void SetInlineRule(StyleSheet sheet, StyleRule rule)
	{
	}

	internal void SetComputedStyle(ref ComputedStyle newStyle)
	{
	}

	public override string ToString()
	{
		return null;
	}

	internal List<string> GetClassesForIteration()
	{
		return null;
	}

	public void AddToClassList(string className)
	{
	}

	public void RemoveFromClassList(string className)
	{
	}

	public void EnableInClassList(string className, bool enable)
	{
	}

	public bool ClassListContains(string cls)
	{
		return false;
	}

	internal object GetProperty(PropertyName key)
	{
		return null;
	}

	internal void SetProperty(PropertyName key, object value)
	{
	}

	internal bool HasProperty(PropertyName key)
	{
		return false;
	}

	private bool TryGetPropertyInternal(PropertyName key, out object value)
	{
		value = null;
		return false;
	}

	private static void CheckUserKeyArgument(PropertyName key)
	{
	}

	private void SetPropertyInternal(PropertyName key, object value)
	{
	}

	private void UpdateCursorStyle(long eventType)
	{
	}

	private VisualElementAnimationSystem GetAnimationSystem()
	{
		return null;
	}

	internal void RegisterAnimation(IValueAnimationUpdate anim)
	{
	}

	internal void UnregisterAnimation(IValueAnimationUpdate anim)
	{
	}

	private void UnregisterRunningAnimations()
	{
	}

	private void RegisterRunningAnimations()
	{
	}

	private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged)
	{
		return null;
	}

	private static void AssignStyleValues(VisualElement ve, StyleValues src)
	{
	}

	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead)
	{
		return default(StyleValues);
	}

	ValueAnimation<StyleValues> ITransitionAnimations.Start(StyleValues to, int durationMs)
	{
		return null;
	}

	private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs)
	{
		return null;
	}

	private void DirtyNextParentWithEventCallback()
	{
	}

	private void SetAsNextParentWithEventCallback()
	{
	}

	internal bool GetCachedNextParentWithEventCallback(out VisualElement nextParent)
	{
		nextParent = null;
		return false;
	}

	private void PropagateCachedNextParentWithEventCallback(VisualElement nextParent, VisualElement stopParent)
	{
	}

	private void UpdateCallbackParentCategories()
	{
	}

	internal bool HasEventCallbacks(EventCategory eventCategory)
	{
		return false;
	}

	internal bool HasParentEventCallbacksOrDefaultActions(EventCategory eventCategory)
	{
		return false;
	}

	internal bool HasEventCallbacksOrDefaultActions(EventCategory eventCategory)
	{
		return false;
	}

	internal bool HasParentEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory)
	{
		return false;
	}

	internal bool HasEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory)
	{
		return false;
	}

	internal bool HasDefaultAction(EventCategory eventCategory)
	{
		return false;
	}

	internal bool ShouldClip()
	{
		return false;
	}

	public void Add(VisualElement child)
	{
	}

	public void Insert(int index, VisualElement element)
	{
	}

	public void Clear()
	{
	}

	public VisualElement ElementAt(int index)
	{
		return null;
	}

	public int IndexOf(VisualElement element)
	{
		return 0;
	}

	internal VisualElement ElementAtTreePath(List<int> childIndexes)
	{
		return null;
	}

	internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes)
	{
		return false;
	}

	public IEnumerable<VisualElement> Children()
	{
		return null;
	}

	public void BringToFront()
	{
	}

	public void SendToBack()
	{
	}

	public void PlaceBehind(VisualElement sibling)
	{
	}

	public void RemoveFromHierarchy()
	{
	}

	public T GetFirstOfType<T>() where T : class
	{
		return null;
	}

	public T GetFirstAncestorOfType<T>() where T : class
	{
		return null;
	}

	internal VisualElement GetFirstAncestorWhere(Predicate<VisualElement> predicate)
	{
		return null;
	}

	public bool Contains(VisualElement child)
	{
		return false;
	}

	private void GatherAllChildren(List<VisualElement> elements)
	{
	}

	public VisualElement FindCommonAncestor(VisualElement other)
	{
		return null;
	}

	internal VisualElement GetRoot()
	{
		return null;
	}

	internal VisualElement GetRootVisualContainer()
	{
		return null;
	}

	internal VisualElement GetNextElementDepthFirst()
	{
		return null;
	}

	internal VisualElement GetPreviousElementDepthFirst()
	{
		return null;
	}

	internal VisualElement RetargetElement(VisualElement retargetAgainst)
	{
		return null;
	}

	internal void GetPivotedMatrixWithLayout(out Matrix4x4 result)
	{
		result = default(Matrix4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static float Min(float a, float b, float c, float d)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static float Max(float a, float b, float c, float d)
	{
		return 0f;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void TransformAlignedRectToParentSpace(ref Rect rect)
	{
	}

	internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect)
	{
		return default(Rect);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect)
	{
	}

	internal static void OrderMinMaxRect(ref Rect rect)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point)
	{
		return default(Vector2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector)
	{
		return default(Vector2);
	}

	internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res)
	{
		res = default(Matrix4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res)
	{
		res = default(Matrix4x4);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs)
	{
	}

	IVisualElementScheduledItem IVisualElementScheduler.Execute(Action<TimerState> timerUpdateEvent)
	{
		return null;
	}

	IVisualElementScheduledItem IVisualElementScheduler.Execute(Action updateEvent)
	{
		return null;
	}

	internal void AddStyleSheetPath(string sheetPath)
	{
	}

	private StyleFloat ResolveLengthValue(Length length, bool isRow)
	{
		return default(StyleFloat);
	}

	private Vector3 ResolveTranslate()
	{
		return default(Vector3);
	}

	private Vector3 ResolveTransformOrigin()
	{
		return default(Vector3);
	}

	private Quaternion ResolveRotation()
	{
		return default(Quaternion);
	}

	private Vector3 ResolveScale()
	{
		return default(Vector3);
	}

	internal static TypeData GetOrCreateTypeData(Type t)
	{
		return null;
	}
}
