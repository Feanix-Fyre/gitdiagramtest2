using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Input Field", 103)]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement
{
	public enum ContentType
	{
		Standard = 0,
		Autocorrected = 1,
		IntegerNumber = 2,
		DecimalNumber = 3,
		Alphanumeric = 4,
		Name = 5,
		EmailAddress = 6,
		Password = 7,
		Pin = 8,
		Custom = 9
	}

	public enum InputType
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2
	}

	public enum CharacterValidation
	{
		None = 0,
		Integer = 1,
		Decimal = 2,
		Alphanumeric = 3,
		Name = 4,
		EmailAddress = 5
	}

	public enum LineType
	{
		SingleLine = 0,
		MultiLineSubmit = 1,
		MultiLineNewline = 2
	}

	public delegate char OnValidateInput(string text, int charIndex, char addedChar);

	[Serializable]
	public class SubmitEvent : UnityEvent<string>
	{
	}

	[Serializable]
	public class EndEditEvent : UnityEvent<string>
	{
	}

	[Serializable]
	public class OnChangeEvent : UnityEvent<string>
	{
	}

	protected enum EditState
	{
		Continue = 0,
		Finish = 1
	}

	[CompilerGenerated]
	private sealed class _003CCaretBlink_003Ed__170 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InputField _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCaretBlink_003Ed__170(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CMouseDragOutsideRect_003Ed__194 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PointerEventData eventData;

		public InputField _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CMouseDragOutsideRect_003Ed__194(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	protected TouchScreenKeyboard m_Keyboard;

	private static readonly char[] kSeparators;

	private static bool s_IsQuestDevice;

	[FormerlySerializedAs("text")]
	[SerializeField]
	protected Text m_TextComponent;

	[SerializeField]
	protected Graphic m_Placeholder;

	[SerializeField]
	private ContentType m_ContentType;

	[SerializeField]
	[FormerlySerializedAs("inputType")]
	private InputType m_InputType;

	[SerializeField]
	[FormerlySerializedAs("asteriskChar")]
	private char m_AsteriskChar;

	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType;

	[SerializeField]
	private LineType m_LineType;

	[FormerlySerializedAs("hideMobileInput")]
	[SerializeField]
	private bool m_HideMobileInput;

	[SerializeField]
	[FormerlySerializedAs("validation")]
	private CharacterValidation m_CharacterValidation;

	[SerializeField]
	[FormerlySerializedAs("characterLimit")]
	private int m_CharacterLimit;

	[FormerlySerializedAs("m_EndEdit")]
	[SerializeField]
	[FormerlySerializedAs("m_OnEndEdit")]
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	private SubmitEvent m_OnSubmit;

	[SerializeField]
	private EndEditEvent m_OnDidEndEdit;

	[FormerlySerializedAs("onValueChange")]
	[SerializeField]
	[FormerlySerializedAs("m_OnValueChange")]
	private OnChangeEvent m_OnValueChanged;

	[SerializeField]
	[FormerlySerializedAs("onValidateInput")]
	private OnValidateInput m_OnValidateInput;

	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	private Color m_CaretColor;

	[SerializeField]
	private bool m_CustomCaretColor;

	[SerializeField]
	private Color m_SelectionColor;

	[Multiline]
	[FormerlySerializedAs("mValue")]
	[SerializeField]
	protected string m_Text;

	[Range(0f, 4f)]
	[SerializeField]
	private float m_CaretBlinkRate;

	[Range(1f, 5f)]
	[SerializeField]
	private int m_CaretWidth;

	[SerializeField]
	private bool m_ReadOnly;

	[SerializeField]
	private bool m_ShouldActivateOnSelect;

	protected int m_CaretPosition;

	protected int m_CaretSelectPosition;

	private RectTransform caretRectTrans;

	protected UIVertex[] m_CursorVerts;

	private TextGenerator m_InputTextCache;

	private CanvasRenderer m_CachedInputRenderer;

	private bool m_PreventFontCallback;

	[NonSerialized]
	protected Mesh m_Mesh;

	private bool m_AllowInput;

	private bool m_ShouldActivateNextUpdate;

	private bool m_UpdateDrag;

	private bool m_DragPositionOutOfBounds;

	private const float kHScrollSpeed = 0.05f;

	private const float kVScrollSpeed = 0.1f;

	protected bool m_CaretVisible;

	private Coroutine m_BlinkCoroutine;

	private float m_BlinkStartTime;

	protected int m_DrawStart;

	protected int m_DrawEnd;

	private Coroutine m_DragCoroutine;

	private string m_OriginalText;

	private bool m_WasCanceled;

	private bool m_HasDoneFocusTransition;

	private WaitForSecondsRealtime m_WaitForSecondsRealtime;

	private bool m_TouchKeyboardAllowsInPlaceEditing;

	private bool m_IsCompositionActive;

	private const string kEmailSpecialCharacters = "!#$%&'*+-/=?^_`{|}~";

	private const string kOculusQuestDeviceModel = "Oculus Quest";

	private Event m_ProcessingEvent;

	private const int k_MaxTextLength = 16382;

	private BaseInput input => null;

	private string compositionString => null;

	protected Mesh mesh => null;

	protected TextGenerator cachedInputTextGenerator => null;

	public bool shouldHideMobileInput
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual bool shouldActivateOnSelect
	{
		get
		{
			return false;
		}
		set
		{
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

	public bool isFocused => false;

	public float caretBlinkRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int caretWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Text textComponent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Graphic placeholder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color caretColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public bool customCaretColor
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Color selectionColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public EndEditEvent onEndEdit
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SubmitEvent onSubmit
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[Obsolete("onValueChange has been renamed to onValueChanged")]
	public OnChangeEvent onValueChange
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public OnChangeEvent onValueChanged
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public OnValidateInput onValidateInput
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int characterLimit
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ContentType contentType
	{
		get
		{
			return default(ContentType);
		}
		set
		{
		}
	}

	public LineType lineType
	{
		get
		{
			return default(LineType);
		}
		set
		{
		}
	}

	public InputType inputType
	{
		get
		{
			return default(InputType);
		}
		set
		{
		}
	}

	public TouchScreenKeyboard touchScreenKeyboard => null;

	public TouchScreenKeyboardType keyboardType
	{
		get
		{
			return default(TouchScreenKeyboardType);
		}
		set
		{
		}
	}

	public CharacterValidation characterValidation
	{
		get
		{
			return default(CharacterValidation);
		}
		set
		{
		}
	}

	public bool readOnly
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool multiLine => false;

	public char asteriskChar
	{
		get
		{
			return '\0';
		}
		set
		{
		}
	}

	public bool wasCanceled => false;

	protected int caretPositionInternal
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected int caretSelectPositionInternal
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool hasSelection => false;

	public int caretPosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int selectionAnchorPosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int selectionFocusPosition
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private static string clipboard
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual float minWidth => 0f;

	public virtual float preferredWidth => 0f;

	public virtual float flexibleWidth => 0f;

	public virtual float minHeight => 0f;

	public virtual float preferredHeight => 0f;

	public virtual float flexibleHeight => 0f;

	public virtual int layoutPriority => 0;

	Transform ICanvasElement.transform => null;

	protected InputField()
	{
	}

	public void SetTextWithoutNotify(string input)
	{
	}

	private void SetText(string value, bool sendCallback = true)
	{
	}

	protected void ClampPos(ref int pos)
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CCaretBlink_003Ed__170))]
	private IEnumerator CaretBlink()
	{
		return null;
	}

	private void SetCaretVisible()
	{
	}

	private void SetCaretActive()
	{
	}

	private void UpdateCaretMaterial()
	{
	}

	protected void OnFocus()
	{
	}

	protected void SelectAll()
	{
	}

	public void MoveTextEnd(bool shift)
	{
	}

	public void MoveTextStart(bool shift)
	{
	}

	private bool TouchScreenKeyboardShouldBeUsed()
	{
		return false;
	}

	private bool InPlaceEditing()
	{
		return false;
	}

	private bool InPlaceEditingChanged()
	{
		return false;
	}

	private RangeInt GetInternalSelection()
	{
		return default(RangeInt);
	}

	private void UpdateKeyboardCaret()
	{
	}

	private void UpdateCaretFromKeyboard()
	{
	}

	protected virtual void LateUpdate()
	{
	}

	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	public Vector2 ScreenToLocal(Vector2 screen)
	{
		return default(Vector2);
	}

	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator)
	{
		return 0;
	}

	protected int GetCharacterIndexFromPosition(Vector2 pos)
	{
		return 0;
	}

	private bool MayDrag(PointerEventData eventData)
	{
		return false;
	}

	public virtual void OnBeginDrag(PointerEventData eventData)
	{
	}

	public virtual void OnDrag(PointerEventData eventData)
	{
	}

	[IteratorStateMachine(typeof(_003CMouseDragOutsideRect_003Ed__194))]
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData)
	{
		return null;
	}

	public virtual void OnEndDrag(PointerEventData eventData)
	{
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	protected EditState KeyPressed(Event evt)
	{
		return default(EditState);
	}

	private bool IsValidChar(char c)
	{
		return false;
	}

	public void ProcessEvent(Event e)
	{
	}

	public virtual void OnUpdateSelected(BaseEventData eventData)
	{
	}

	private string GetSelectedString()
	{
		return null;
	}

	private int FindtNextWordBegin()
	{
		return 0;
	}

	private void MoveRight(bool shift, bool ctrl)
	{
	}

	private int FindtPrevWordBegin()
	{
		return 0;
	}

	private void MoveLeft(bool shift, bool ctrl)
	{
	}

	private int DetermineCharacterLine(int charPos, TextGenerator generator)
	{
		return 0;
	}

	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar)
	{
		return 0;
	}

	private int LineDownCharacterPosition(int originalPos, bool goToLastChar)
	{
		return 0;
	}

	private void MoveDown(bool shift)
	{
	}

	private void MoveDown(bool shift, bool goToLastChar)
	{
	}

	private void MoveUp(bool shift)
	{
	}

	private void MoveUp(bool shift, bool goToFirstChar)
	{
	}

	private void Delete()
	{
	}

	private void ForwardSpace()
	{
	}

	private void Backspace()
	{
	}

	private void Insert(char c)
	{
	}

	private void UpdateTouchKeyboardFromEditChanges()
	{
	}

	private void SendOnValueChangedAndUpdateLabel()
	{
	}

	private void SendOnValueChanged()
	{
	}

	protected void SendOnEndEdit()
	{
	}

	protected void SendOnSubmit()
	{
	}

	protected virtual void Append(string input)
	{
	}

	protected virtual void Append(char input)
	{
	}

	protected void UpdateLabel()
	{
	}

	private bool IsSelectionVisible()
	{
		return false;
	}

	private static int GetLineStartPosition(TextGenerator gen, int line)
	{
		return 0;
	}

	private static int GetLineEndPosition(TextGenerator gen, int line)
	{
		return 0;
	}

	private void SetDrawRangeToContainCaretPosition(int caretPos)
	{
	}

	public void ForceLabelUpdate()
	{
	}

	private void MarkGeometryAsDirty()
	{
	}

	public virtual void Rebuild(CanvasUpdate update)
	{
	}

	public virtual void LayoutComplete()
	{
	}

	public virtual void GraphicUpdateComplete()
	{
	}

	private void UpdateGeometry()
	{
	}

	private void AssignPositioningIfNeeded()
	{
	}

	private void OnFillVBO(Mesh vbo)
	{
	}

	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset)
	{
	}

	private void CreateCursorVerts()
	{
	}

	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset)
	{
	}

	protected char Validate(string text, int pos, char ch)
	{
		return '\0';
	}

	public void ActivateInputField()
	{
	}

	private void ActivateInputFieldInternal()
	{
	}

	public override void OnSelect(BaseEventData eventData)
	{
	}

	public virtual void OnPointerClick(PointerEventData eventData)
	{
	}

	public void DeactivateInputField()
	{
	}

	public override void OnDeselect(BaseEventData eventData)
	{
	}

	public virtual void OnSubmit(BaseEventData eventData)
	{
	}

	private void EnforceContentType()
	{
	}

	private void EnforceTextHOverflow()
	{
	}

	private void SetToCustomIfContentTypeIsNot(params ContentType[] allowedContentTypes)
	{
	}

	private void SetToCustom()
	{
	}

	protected override void DoStateTransition(SelectionState state, bool instant)
	{
	}

	public virtual void CalculateLayoutInputHorizontal()
	{
	}

	public virtual void CalculateLayoutInputVertical()
	{
	}
}
