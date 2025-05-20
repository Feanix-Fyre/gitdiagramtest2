namespace UnityEngine.UIElements;

internal abstract class BaseVisualTreeHierarchyTrackerUpdater : BaseVisualTreeUpdater
{
	private enum State
	{
		Waiting = 0,
		TrackingAddOrMove = 1,
		TrackingRemove = 2
	}

	private State m_State;

	private VisualElement m_CurrentChangeElement;

	private VisualElement m_CurrentChangeParent;

	protected abstract void OnHierarchyChange(VisualElement ve, HierarchyChangeType type);

	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	public override void Update()
	{
	}

	private void ProcessNewChange(VisualElement ve)
	{
	}

	private void ProcessAddOrMove(VisualElement ve)
	{
	}

	private void ProcessRemove(VisualElement ve)
	{
	}
}
