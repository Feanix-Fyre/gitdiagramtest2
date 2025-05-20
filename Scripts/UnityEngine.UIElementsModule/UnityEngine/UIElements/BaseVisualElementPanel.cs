using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Yoga;

namespace UnityEngine.UIElements;

internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
{
	private UIElementsBridge m_UIElementsBridge;

	private float m_Scale;

	internal YogaConfig yogaConfig;

	private float m_PixelsPerPoint;

	internal ElementUnderPointer m_TopElementUnderPointers;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<Material> updateMaterial;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<IPanel> beforeUpdate;

	public abstract EventInterests IMGUIEventInterests { get; set; }

	public abstract ScriptableObject ownerObject { get; protected set; }

	public abstract SavePersistentViewData saveViewData { get; }

	public abstract GetViewDataDictionary getViewDataDictionary { get; }

	public abstract int IMGUIContainersCount { get; set; }

	public abstract FocusController focusController { get; set; }

	public abstract IMGUIContainer rootIMGUIContainer { get; }

	internal UIElementsBridge uiElementsBridge => null;

	internal float scale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal float pixelsPerPoint
	{
		set
		{
		}
	}

	public float scaledPixelsPerPoint => 0f;

	public float referenceSpritePixelsPerUnit { get; set; }

	internal PanelClearSettings clearSettings { get; set; }

	internal bool duringLayoutPhase { get; set; }

	internal abstract uint version { get; }

	internal abstract uint hierarchyVersion { get; }

	internal virtual RepaintData repaintData { get; set; }

	internal virtual ICursorManager cursorManager { get; set; }

	public ContextualMenuManager contextualMenuManager { get; internal set; }

	public abstract VisualElement visualTree { get; }

	public abstract EventDispatcher dispatcher { get; set; }

	internal abstract IScheduler scheduler { get; }

	internal abstract IStylePropertyAnimationSystem styleAnimationSystem { get; set; }

	public abstract ContextType contextType { get; protected set; }

	internal bool disposed { get; private set; }

	internal abstract Shader standardShader { get; }

	internal virtual Shader standardWorldSpaceShader => null;

	public abstract AtlasBase atlas { get; set; }

	internal event Action<BaseVisualElementPanel> panelDisposed
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

	internal event Action standardShaderChanged
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

	internal event Action standardWorldSpaceShaderChanged
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

	internal event Action atlasChanged
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

	internal event HierarchyEvent hierarchyChanged
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

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public abstract void Repaint(Event e);

	public abstract void ValidateFocus();

	public abstract void ValidateLayout();

	public abstract void UpdateAnimations();

	public abstract void UpdateBindings();

	public abstract void ApplyStyles();

	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag);

	internal void SendEvent(EventBase e, DispatchMode dispatchMode = DispatchMode.Default)
	{
	}

	public abstract VisualElement Pick(Vector2 point);

	public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked);

	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase);

	internal VisualElement GetTopElementUnderPointer(int pointerId)
	{
		return null;
	}

	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent)
	{
		return null;
	}

	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent)
	{
	}

	internal void CommitElementUnderPointers()
	{
	}

	protected void InvokeAtlasChanged()
	{
	}

	internal void InvokeUpdateMaterial(Material mat)
	{
	}

	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
	{
	}

	internal void InvokeBeforeUpdate()
	{
	}

	internal void UpdateElementUnderPointers()
	{
	}

	void IGroupBox.OnOptionAdded(IGroupBoxOption option)
	{
	}

	void IGroupBox.OnOptionRemoved(IGroupBoxOption option)
	{
	}

	public virtual void Update()
	{
	}
}
