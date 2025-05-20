using Unity.Profiling;

namespace UnityEngine.UIElements;

internal class VisualTreeHierarchyFlagsUpdater : BaseVisualTreeUpdater
{
	private uint m_Version;

	private uint m_LastVersion;

	private static readonly string s_Description;

	private static readonly ProfilerMarker s_ProfilerMarker;

	public override ProfilerMarker profilerMarker => default(ProfilerMarker);

	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	private static void DirtyHierarchy(VisualElement ve, VisualElementFlags mustDirtyFlags)
	{
	}

	private static void DirtyBoundingBoxHierarchy(VisualElement ve)
	{
	}

	public override void Update()
	{
	}
}
