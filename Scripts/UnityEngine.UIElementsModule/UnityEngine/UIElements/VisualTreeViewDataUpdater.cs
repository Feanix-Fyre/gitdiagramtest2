using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements;

internal class VisualTreeViewDataUpdater : BaseVisualTreeUpdater
{
	private HashSet<VisualElement> m_UpdateList;

	private HashSet<VisualElement> m_ParentList;

	private uint m_Version;

	private uint m_LastVersion;

	private static readonly string s_Description;

	private static readonly ProfilerMarker s_ProfilerMarker;

	public override ProfilerMarker profilerMarker => default(ProfilerMarker);

	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	public override void Update()
	{
	}

	private void ValidateViewDataOnSubTree(VisualElement ve, bool enablePersistence)
	{
	}

	private void PropagateToParents(VisualElement ve)
	{
	}
}
