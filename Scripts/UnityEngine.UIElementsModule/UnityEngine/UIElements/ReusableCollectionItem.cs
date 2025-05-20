using System;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements;

internal class ReusableCollectionItem
{
	protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback;

	public virtual VisualElement rootElement => null;

	public VisualElement bindableElement { get; protected set; }

	public ValueAnimation<StyleValues> animator { get; set; }

	public int index { get; set; }

	public int id { get; set; }

	internal bool isDragGhost { get; private set; }

	public event Action<ReusableCollectionItem> onGeometryChanged
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

	internal event Action<ReusableCollectionItem> onDestroy
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

	public virtual void Init(VisualElement item)
	{
	}

	public virtual void PreAttachElement()
	{
	}

	public virtual void DetachElement()
	{
	}

	public virtual void DestroyElement()
	{
	}

	public virtual void SetSelected(bool selected)
	{
	}

	public virtual void SetDragGhost(bool dragGhost)
	{
	}

	protected void OnGeometryChanged(GeometryChangedEvent evt)
	{
	}
}
