using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements;

internal class VisualElementAnimationSystem : BaseVisualTreeUpdater
{
	private HashSet<IValueAnimationUpdate> m_Animations;

	private List<IValueAnimationUpdate> m_IterationList;

	private bool m_HasNewAnimations;

	private bool m_IterationListDirty;

	private static readonly string s_Description;

	private static readonly ProfilerMarker s_ProfilerMarker;

	private static readonly string s_StylePropertyAnimationDescription;

	private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker;

	private long lastUpdate;

	public override ProfilerMarker profilerMarker => default(ProfilerMarker);

	private static ProfilerMarker stylePropertyAnimationProfilerMarker => default(ProfilerMarker);

	public void UnregisterAnimation(IValueAnimationUpdate anim)
	{
	}

	public void UnregisterAnimations(List<IValueAnimationUpdate> anims)
	{
	}

	public void RegisterAnimation(IValueAnimationUpdate anim)
	{
	}

	public void RegisterAnimations(List<IValueAnimationUpdate> anims)
	{
	}

	public override void Update()
	{
	}

	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}
}
