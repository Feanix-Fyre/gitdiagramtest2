using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
{
	private static readonly PropertyName s_BindingRequestObjectVEPropertyName;

	private static readonly PropertyName s_AdditionalBindingObjectVEPropertyName;

	private static readonly string s_Description;

	private static readonly ProfilerMarker s_ProfilerMarker;

	private static readonly ProfilerMarker s_ProfilerBindingRequestsMarker;

	private static ProfilerMarker s_MarkerUpdate;

	private static ProfilerMarker s_MarkerPoll;

	private readonly HashSet<VisualElement> m_ElementsWithBindings;

	private readonly HashSet<VisualElement> m_ElementsToAdd;

	private readonly HashSet<VisualElement> m_ElementsToRemove;

	private long m_LastUpdateTime;

	private HashSet<VisualElement> m_ElementsToBind;

	private List<IBinding> updatedBindings;

	public override ProfilerMarker profilerMarker => default(ProfilerMarker);

	public static bool disableBindingsThrottling { get; }

	public Dictionary<object, object> temporaryObjectCache { get; }

	private IBinding GetBindingObjectFromElement(VisualElement ve)
	{
		return null;
	}

	private void StartTracking(VisualElement ve)
	{
	}

	private void StopTracking(VisualElement ve)
	{
	}

	public static IBinding GetAdditionalBinding(VisualElement ve)
	{
		return null;
	}

	private void StartTrackingRecursive(VisualElement ve)
	{
	}

	private void StopTrackingRecursive(VisualElement ve)
	{
	}

	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	protected override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type)
	{
	}

	private static long CurrentTime()
	{
		return 0L;
	}

	public void PerformTrackingOperations()
	{
	}

	public override void Update()
	{
	}

	private void UpdateBindings()
	{
	}
}
