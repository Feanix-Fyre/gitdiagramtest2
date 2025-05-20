using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public abstract class TextInputBaseField<TValueType> : BaseField<TValueType>
{
	public new class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription>
	{
		private UxmlIntAttributeDescription m_MaxLength;

		private UxmlBoolAttributeDescription m_Password;

		private UxmlStringAttributeDescription m_MaskCharacter;

		private UxmlBoolAttributeDescription m_IsReadOnly;

		private UxmlBoolAttributeDescription m_IsDelayed;

		private UxmlBoolAttributeDescription m_HideMobileInput;

		private UxmlEnumAttributeDescription<TouchScreenKeyboardType> m_KeyboardType;

		private UxmlBoolAttributeDescription m_AutoCorrection;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	protected internal abstract class TextInputBase : VisualElement
	{
		internal ScrollView scrollView;

		internal VisualElement multilineContainer;

		public static readonly string innerComponentsModifierName;

		public static readonly string innerTextElementUssClassName;

		internal static readonly string innerTextElementWithScrollViewUssClassName;

		public static readonly string horizontalVariantInnerTextElementUssClassName;

		public static readonly string verticalVariantInnerTextElementUssClassName;

		public static readonly string verticalHorizontalVariantInnerTextElementUssClassName;

		public static readonly string innerScrollviewUssClassName;

		public static readonly string innerViewportUssClassName;

		public static readonly string innerContentContainerUssClassName;

		internal Vector2 scrollOffset;

		private bool m_ScrollViewWasClamped;

		private Vector2 lastCursorPos;

		private ScrollerVisibility m_VerticalScrollerVisibility;

		internal TextElement textElement { get; private set; }

		public ITextSelection textSelection => null;

		public ITextEdition textEdition => null;

		internal string originalText => null;

		public bool isReadOnly => false;

		public int maxLength
		{
			set
			{
			}
		}

		public char maskChar
		{
			set
			{
			}
		}

		public virtual bool isPasswordField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool isDragging
		{
			[CompilerGenerated]
			set
			{
				_003CisDragging_003Ek__BackingField = value;
			}
		}

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void SelectAll()
		{
		}

		internal void SelectNone()
		{
		}

		protected virtual TValueType StringToValue(string str)
		{
			return default(TValueType);
		}

		internal void UpdateValueFromText()
		{
		}

		internal void UpdateTextFromValue()
		{
		}

		internal void MoveFocusToCompositeRoot()
		{
		}

		internal TextInputBase()
		{
		}

		private void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent<float> evt)
		{
		}

		internal void SetSingleLine()
		{
		}

		internal void SetMultiline()
		{
		}

		private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e)
		{
		}

		private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e)
		{
		}

		internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		internal virtual bool AcceptCharacter(char c)
		{
			return false;
		}

		internal void UpdateScrollOffset(bool isBackspace = false)
		{
		}

		internal void UpdateScrollOffset(bool isBackspace, bool widthChanged)
		{
		}

		private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged)
		{
			return default(Vector2);
		}

		internal void SetScrollViewMode()
		{
		}

		private void SetMultilineContainerStyle()
		{
		}

		private void RemoveSingleLineComponents()
		{
		}

		private void RemoveMultilineComponents()
		{
		}
	}

	private static CustomStyleProperty<Color> s_SelectionColorProperty;

	private static CustomStyleProperty<Color> s_CursorColorProperty;

	private int m_VisualInputTabIndex;

	private TextInputBase m_TextInputBase;

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	internal static readonly string multilineContainerClassName;

	public static readonly string singleLineInputUssClassName;

	public static readonly string multilineInputUssClassName;

	internal static readonly string multilineInputWithScrollViewUssClassName;

	public static readonly string textInputUssName;

	protected internal TextInputBase textInputBase => null;

	public string text
	{
		get
		{
			return null;
		}
		protected internal set
		{
		}
	}

	public bool isReadOnly
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isPasswordField
	{
		set
		{
		}
	}

	public bool autoCorrection
	{
		set
		{
		}
	}

	public bool hideMobileInput
	{
		set
		{
		}
	}

	public TouchScreenKeyboardType keyboardType
	{
		set
		{
		}
	}

	public ITextEdition textEdition => null;

	public int maxLength
	{
		set
		{
		}
	}

	public bool isDelayed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public char maskChar
	{
		set
		{
		}
	}

	protected event Action<bool> onIsReadOnlyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected abstract string ValueToString(TValueType value);

	protected abstract TValueType StringToValue(string str);

	protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase textInputBase)
		: base((string)null)
	{
	}

	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e)
	{
	}

	[EventInterest(new Type[]
	{
		typeof(NavigationSubmitEvent),
		typeof(FocusInEvent),
		typeof(FocusEvent),
		typeof(BlurEvent)
	})]
	protected override void ExecuteDefaultActionAtTarget(EventBase evt)
	{
	}

	protected override void UpdateMixedValueContent()
	{
	}

	internal virtual void UpdateValueFromText()
	{
	}

	internal virtual void UpdateTextFromValue()
	{
	}
}
