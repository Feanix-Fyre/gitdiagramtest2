using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public abstract class BaseField<TValueType> : BindableElement, INotifyValueChanged<TValueType>, IEditableElement
{
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		private UxmlStringAttributeDescription m_Label;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		internal static List<string> ParseChoiceList(string choicesFromBag)
		{
			return null;
		}
	}

	public static readonly string ussClassName;

	public static readonly string labelUssClassName;

	public static readonly string inputUssClassName;

	public static readonly string noLabelVariantUssClassName;

	public static readonly string labelDraggerVariantUssClassName;

	public static readonly string mixedValueLabelUssClassName;

	public static readonly string alignedFieldUssClassName;

	private static readonly string inspectorFieldUssClassName;

	protected internal static readonly string mixedValueString;

	protected internal static readonly PropertyName serializedPropertyCopyName;

	private static CustomStyleProperty<float> s_LabelWidthRatioProperty;

	private static CustomStyleProperty<float> s_LabelExtraPaddingProperty;

	private static CustomStyleProperty<float> s_LabelBaseMinWidthProperty;

	private static CustomStyleProperty<float> s_LabelExtraContextWidthProperty;

	private float m_LabelWidthRatio;

	private float m_LabelExtraPadding;

	private float m_LabelBaseMinWidth;

	private float m_LabelExtraContextWidth;

	private VisualElement m_VisualInput;

	[SerializeField]
	private TValueType m_Value;

	private bool m_ShowMixedValue;

	private Label m_MixedValueLabel;

	private bool m_SkipValidation;

	private VisualElement m_CachedContextWidthElement;

	private VisualElement m_CachedInspectorElement;

	internal VisualElement visualInput
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected TValueType rawValue
	{
		get
		{
			return default(TValueType);
		}
		set
		{
		}
	}

	public virtual TValueType value
	{
		get
		{
			return default(TValueType);
		}
		set
		{
		}
	}

	public Label labelElement { get; private set; }

	public string label
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool showMixedValue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected Label mixedValueLabel => null;

	Action IEditableElement.editingStarted
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	Action IEditableElement.editingEnded
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	internal event Func<TValueType, TValueType> onValidateValue
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

	internal BaseField(string label)
	{
	}

	protected BaseField(string label, VisualElement visualInput)
	{
	}

	internal virtual bool EqualsCurrentValue(TValueType value)
	{
		return false;
	}

	private void OnAttachToPanel(AttachToPanelEvent e)
	{
	}

	private void OnDetachFromPanel(DetachFromPanelEvent e)
	{
	}

	internal virtual void RegisterEditingCallbacks()
	{
	}

	internal virtual void UnregisterEditingCallbacks()
	{
	}

	internal void StartEditing(EventBase e)
	{
	}

	internal void EndEditing(EventBase e)
	{
	}

	private void OnCustomStyleResolved(CustomStyleResolvedEvent evt)
	{
	}

	private void OnInspectorFieldGeometryChanged(GeometryChangedEvent e)
	{
	}

	private void AlignLabel()
	{
	}

	internal TValueType ValidatedValue(TValueType value)
	{
		return default(TValueType);
	}

	protected virtual void UpdateMixedValueContent()
	{
	}

	public virtual void SetValueWithoutNotify(TValueType newValue)
	{
	}

	internal override void OnViewDataReady()
	{
	}

	internal override Rect GetTooltipRect()
	{
		return default(Rect);
	}
}
