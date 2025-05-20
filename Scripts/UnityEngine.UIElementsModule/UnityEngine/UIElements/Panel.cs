using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal class Panel : BaseVisualElementPanel
{
	private VisualElement m_RootContainer;

	private VisualTreeUpdater m_VisualTreeUpdater;

	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem;

	private string m_PanelName;

	private uint m_Version;

	private uint m_RepaintVersion;

	private uint m_HierarchyVersion;

	private ProfilerMarker m_MarkerBeforeUpdate;

	private ProfilerMarker m_MarkerUpdate;

	private ProfilerMarker m_MarkerLayout;

	private ProfilerMarker m_MarkerBindings;

	private ProfilerMarker m_MarkerAnimations;

	private static ProfilerMarker s_MarkerPickAll;

	private TimerEventScheduler m_Scheduler;

	private bool m_JustReceivedFocus;

	private Shader m_StandardShader;

	private AtlasBase m_Atlas;

	private bool m_ValidatingLayout;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<Panel> beforeAnyRepaint;

	public sealed override VisualElement visualTree => null;

	public sealed override EventDispatcher dispatcher { get; set; }

	public TimerEventScheduler timerEventScheduler => null;

	internal override IScheduler scheduler => null;

	internal override IStylePropertyAnimationSystem styleAnimationSystem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override ScriptableObject ownerObject { get; protected set; }

	public override ContextType contextType { get; protected set; }

	public override SavePersistentViewData saveViewData { get; }

	public override GetViewDataDictionary getViewDataDictionary { get; }

	public sealed override FocusController focusController { get; set; }

	public override EventInterests IMGUIEventInterests { get; set; }

	private static LoadResourceFunction loadResourceFunc { get; }

	internal string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private static TimeMsFunction TimeSinceStartup { get; }

	public override int IMGUIContainersCount { get; set; }

	public override IMGUIContainer rootIMGUIContainer { get; }

	internal override uint version => 0u;

	internal override uint hierarchyVersion => 0u;

	internal override Shader standardShader => null;

	public override AtlasBase atlas
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal static Object LoadResource(string pathName, Type type, float dpiScaling)
	{
		return null;
	}

	internal void Focus()
	{
	}

	internal void Blur()
	{
	}

	public override void ValidateFocus()
	{
	}

	private void CreateMarkers()
	{
	}

	public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public static long TimeSinceStartupMs()
	{
		return 0L;
	}

	internal static long DefaultTimeSinceStartupMs()
	{
		return 0L;
	}

	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false)
	{
		return null;
	}

	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false)
	{
		return null;
	}

	public override VisualElement PickAll(Vector2 point, List<VisualElement> picked)
	{
		return null;
	}

	public override VisualElement Pick(Vector2 point)
	{
		return null;
	}

	public override void ValidateLayout()
	{
	}

	public override void UpdateAnimations()
	{
	}

	public override void UpdateBindings()
	{
	}

	public override void ApplyStyles()
	{
	}

	private void UpdateForRepaint()
	{
	}

	public override void Repaint(Event e)
	{
	}

	internal override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	internal override IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase)
	{
		return null;
	}
}
