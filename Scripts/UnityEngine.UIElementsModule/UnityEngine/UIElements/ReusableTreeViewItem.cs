using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

internal class ReusableTreeViewItem : ReusableCollectionItem
{
	private Toggle m_Toggle;

	private VisualElement m_Container;

	private VisualElement m_IndentElement;

	private VisualElement m_BindableContainer;

	private VisualElement m_Checkmark;

	private int m_Depth;

	private float m_IndentWidth;

	private EventCallback<PointerUpEvent> m_PointerUpCallback;

	private EventCallback<ChangeEvent<bool>> m_ToggleValueChangedCallback;

	private EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback;

	public override VisualElement rootElement => null;

	public event Action<PointerUpEvent> onPointerUp
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

	public event Action<ChangeEvent<bool>> onToggleValueChanged
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

	public override void Init(VisualElement item)
	{
	}

	protected void InitExpandHierarchy(VisualElement root, VisualElement item)
	{
	}

	public override void PreAttachElement()
	{
	}

	public override void DetachElement()
	{
	}

	public void Indent(int depth)
	{
	}

	public void SetExpandedWithoutNotify(bool expanded)
	{
	}

	public void SetToggleVisibility(bool visible)
	{
	}

	private void OnToggleGeometryChanged(GeometryChangedEvent evt)
	{
	}

	private void UpdateIndentLayout()
	{
	}

	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	private void OnToggleValueChanged(ChangeEvent<bool> evt)
	{
	}
}
