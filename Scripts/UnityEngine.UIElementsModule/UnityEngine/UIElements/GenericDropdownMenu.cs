using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

public class GenericDropdownMenu : IGenericMenu
{
	internal class MenuItem
	{
		public string name;

		public VisualElement element;

		public Action action;

		public Action<object> actionUserData;
	}

	public static readonly string ussClassName;

	public static readonly string itemUssClassName;

	public static readonly string labelUssClassName;

	public static readonly string containerInnerUssClassName;

	public static readonly string containerOuterUssClassName;

	public static readonly string checkmarkUssClassName;

	public static readonly string separatorUssClassName;

	private List<MenuItem> m_Items;

	private VisualElement m_MenuContainer;

	private VisualElement m_OuterContainer;

	private ScrollView m_ScrollView;

	private VisualElement m_PanelRootVisualContainer;

	private VisualElement m_TargetElement;

	private Rect m_DesiredRect;

	private KeyboardNavigationManipulator m_NavigationManipulator;

	private Vector2 m_MousePosition;

	internal bool isSingleSelectionDropdown { get; set; }

	internal bool closeOnParentResize { get; set; }

	public VisualElement contentContainer => null;

	private void OnAttachToPanel(AttachToPanelEvent evt)
	{
	}

	private void OnDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	private void Hide(bool giveFocusBack = false)
	{
	}

	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
	{
	}

	private bool Apply(KeyboardNavigationOperation op)
	{
		return false;
	}

	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	private void OnFocusOut(FocusOutEvent evt)
	{
	}

	private void OnParentResized(GeometryChangedEvent evt)
	{
	}

	private void UpdateSelection(VisualElement target)
	{
	}

	private void ChangeSelectedIndex(int newIndex, int previousIndex)
	{
	}

	private int GetSelectedIndex()
	{
		return 0;
	}

	public void AddItem(string itemName, bool isChecked, Action action)
	{
	}

	public void AddItem(string itemName, bool isChecked, Action<object> action, object data)
	{
	}

	public void AddSeparator(string path)
	{
	}

	private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, object data = null)
	{
		return null;
	}

	public void DropDown(Rect position, VisualElement targetElement = null, bool anchored = false)
	{
	}

	private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	private void OnContainerGeometryChanged(GeometryChangedEvent evt)
	{
	}

	private void EnsureVisibilityInParent()
	{
	}
}
