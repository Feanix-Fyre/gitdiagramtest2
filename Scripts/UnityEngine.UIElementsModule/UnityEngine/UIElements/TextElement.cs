using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class TextElement : BindableElement, INotifyValueChanged<string>, ITextEdition, IExperimentalFeatures, ITextSelection
{
	public new class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
	{
	}

	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text;

		private UxmlBoolAttributeDescription m_EnableRichText;

		private UxmlBoolAttributeDescription m_ParseEscapeSequences;

		private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public static readonly string ussClassName;

	private string m_Text;

	private bool m_EnableRichText;

	private bool m_ParseEscapeSequences;

	private bool m_DisplayTooltipWhenElided;

	internal static readonly string k_EllipsisText;

	internal string elidedText;

	private bool m_WasElided;

	internal TextEditingManipulator editingManipulator;

	private bool m_Multiline;

	internal TouchScreenKeyboard m_TouchScreenKeyboard;

	internal TouchScreenKeyboardType m_KeyboardType;

	private bool m_HideMobileInput;

	private bool m_IsReadOnly;

	private int m_MaxLength;

	private string m_RenderedText;

	private string m_OriginalText;

	private char m_MaskChar;

	private bool m_IsPassword;

	private bool m_AutoCorrection;

	private TextSelectingManipulator m_SelectingManipulator;

	private bool m_IsSelectable;

	private Color m_SelectionColor;

	private Color m_CursorColor;

	private float m_CursorWidth;

	internal UITKTextHandle uitkTextHandle { get; set; }

	public virtual string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool enableRichText
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool parseEscapeSequences
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool displayTooltipWhenElided
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool isElided { get; private set; }

	internal bool hasFocus => false;

	string INotifyValueChanged<string>.value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ITextEdition edition => null;

	bool ITextEdition.multiline
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	TouchScreenKeyboardType ITextEdition.keyboardType
	{
		get
		{
			return default(TouchScreenKeyboardType);
		}
		set
		{
		}
	}

	bool ITextEdition.hideMobileInput
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool ITextEdition.isReadOnly
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	int ITextEdition.maxLength
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	bool ITextEdition.isDelayed
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	Func<char, bool> ITextEdition.AcceptCharacter
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	Action<bool> ITextEdition.UpdateScrollOffset
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	Action ITextEdition.UpdateValueFromText
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	Action ITextEdition.UpdateTextFromValue
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	Action ITextEdition.MoveFocusToCompositeRoot
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	char ITextEdition.maskChar
	{
		set
		{
		}
	}

	private char effectiveMaskChar => '\0';

	bool ITextEdition.isPassword
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	bool ITextEdition.autoCorrection
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal string renderedText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal string originalText => null;

	public ITextSelection selection => null;

	bool ITextSelection.isSelectable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	int ITextSelection.cursorIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	int ITextSelection.selectIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	bool ITextSelection.doubleClickSelectsWord
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
	}

	bool ITextSelection.tripleClickSelectsLine
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
	}

	bool ITextSelection.selectAllOnFocus
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	bool ITextSelection.selectAllOnMouseUp
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	Vector2 ITextSelection.cursorPosition => default(Vector2);

	float ITextSelection.lineHeightAtCursorPosition => 0f;

	Color ITextSelection.selectionColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	Color ITextSelection.cursorColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	float ITextSelection.cursorWidth => 0f;

	internal TextSelectingManipulator selectingManipulator => null;

	private void OnGeometryChanged(GeometryChangedEvent e)
	{
	}

	internal void OnGenerateVisualContent(MeshGenerationContext mgc)
	{
	}

	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
	{
		return null;
	}

	private void UpdateTooltip()
	{
	}

	private void UpdateVisibleText()
	{
	}

	private bool ShouldElide()
	{
		return false;
	}

	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	void INotifyValueChanged<string>.SetValueWithoutNotify(string newValue)
	{
	}

	private void ProcessMenuCommand(string command)
	{
	}

	private void Cut(DropdownMenuAction a)
	{
	}

	private void Copy(DropdownMenuAction a)
	{
	}

	private void Paste(DropdownMenuAction a)
	{
	}

	private void BuildContextualMenu(ContextualMenuPopulateEvent evt)
	{
	}

	private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a)
	{
		return default(DropdownMenuAction.Status);
	}

	private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a)
	{
		return default(DropdownMenuAction.Status);
	}

	private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a)
	{
		return default(DropdownMenuAction.Status);
	}

	[EventInterest(new Type[]
	{
		typeof(ContextualMenuPopulateEvent),
		typeof(FocusInEvent),
		typeof(FocusOutEvent),
		typeof(KeyDownEvent),
		typeof(KeyUpEvent),
		typeof(FocusEvent),
		typeof(BlurEvent),
		typeof(ValidateCommandEvent),
		typeof(ExecuteCommandEvent),
		typeof(PointerDownEvent),
		typeof(PointerUpEvent),
		typeof(PointerMoveEvent),
		typeof(NavigationMoveEvent),
		typeof(NavigationSubmitEvent),
		typeof(NavigationCancelEvent)
	})]
	protected override void ExecuteDefaultActionAtTarget(EventBase evt)
	{
	}

	void ITextEdition.SaveValueAndText()
	{
	}

	void ITextEdition.RestoreValueAndText()
	{
	}

	void ITextEdition.UpdateText(string value)
	{
	}

	string ITextEdition.CullString(string s)
	{
		return null;
	}

	void ITextSelection.SelectAll()
	{
	}

	void ITextSelection.SelectNone()
	{
	}

	bool ITextSelection.HasSelection()
	{
		return false;
	}

	private void DrawHighlighting(MeshGenerationContext mgc)
	{
	}

	internal void DrawCaret(MeshGenerationContext mgc)
	{
	}

	private int GetLastCharacterAt(int lineIndex)
	{
		return 0;
	}
}
