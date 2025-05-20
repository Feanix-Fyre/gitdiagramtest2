using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

internal class UIRRepaintUpdater : BaseVisualTreeUpdater
{
	private BaseVisualElementPanel attachedPanel;

	internal RenderChain renderChain;

	private static readonly string s_Description;

	private static readonly ProfilerMarker s_ProfilerMarker;

	public override ProfilerMarker profilerMarker => default(ProfilerMarker);

	public bool drawStats { get; }

	public bool breakBatches { get; }

	protected bool disposed { get; private set; }

	public override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	public override void Update()
	{
	}

	protected virtual RenderChain CreateRenderChain()
	{
		return null;
	}

	static UIRRepaintUpdater()
	{
	}

	private static void OnGraphicsResourcesRecreate(bool recreate)
	{
	}

	private void OnPanelChanged(BaseVisualElementPanel obj)
	{
	}

	private void AttachToPanel()
	{
	}

	private void DetachFromPanel()
	{
	}

	private void InitRenderChain()
	{
	}

	internal void DestroyRenderChain()
	{
	}

	private void OnPanelAtlasChanged()
	{
	}

	private void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
	{
	}

	private void OnPanelStandardShaderChanged()
	{
	}

	private void OnPanelStandardWorldSpaceShaderChanged()
	{
	}

	private void ResetAllElementsDataRecursive(VisualElement ve)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
