using System;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public abstract class BasePopupField<TValueType, TValueChoice> : BaseField<TValueType>
{
	private class PopupTextElement : TextElement
	{
		protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
		{
			return default(Vector2);
		}
	}

	internal List<TValueChoice> m_Choices;

	private TextElement m_TextElement;

	private VisualElement m_ArrowElement;

	internal Func<TValueChoice, string> m_FormatSelectedValueCallback;

	internal Func<TValueChoice, string> m_FormatListItemCallback;

	internal Func<IGenericMenu> createMenuCallback;

	public new static readonly string ussClassName;

	public static readonly string textUssClassName;

	public static readonly string arrowUssClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	protected TextElement textElement => null;

	public virtual List<TValueChoice> choices
	{
		set
		{
		}
	}

	internal abstract string GetValueToDisplay();

	internal abstract string GetListItemToDisplay(TValueType item);

	internal abstract void AddMenuItems(IGenericMenu menu);

	public override void SetValueWithoutNotify(TValueType newValue)
	{
	}

	internal BasePopupField(string label)
		: base((string)null)
	{
	}

	private void OnPointerDownEvent(PointerDownEvent evt)
	{
	}

	private void OnPointerMoveEvent(PointerMoveEvent evt)
	{
	}

	private bool ContainsPointer(int pointerId)
	{
		return false;
	}

	private void ProcessPointerDown<T>(PointerEventBase<T> evt) where T : PointerEventBase<T>, new()
	{
	}

	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	internal void ShowMenu()
	{
	}

	protected override void UpdateMixedValueContent()
	{
	}
}
