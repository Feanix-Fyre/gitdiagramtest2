using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal class UIRLayoutUpdater : BaseVisualTreeUpdater
{
	private static readonly string s_Description;

	private static readonly ProfilerMarker s_ProfilerMarker;

	private List<KeyValuePair<Rect, VisualElement>> changeEventsList;

	public override ProfilerMarker profilerMarker => default(ProfilerMarker);

	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	public override void Update()
	{
	}

	private void UpdateSubTree(VisualElement ve, bool isDisplayed, List<KeyValuePair<Rect, VisualElement>> changeEvents)
	{
	}

	private void DispatchChangeEvents(List<KeyValuePair<Rect, VisualElement>> changeEvents, int currentLayoutPass)
	{
	}
}
