using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class RenderGraphDebugParams
{
	private static class Strings
	{
		public static readonly DebugUI.Widget.NameAndTooltip ClearRenderTargetsAtCreation;

		public static readonly DebugUI.Widget.NameAndTooltip DisablePassCulling;

		public static readonly DebugUI.Widget.NameAndTooltip ImmediateMode;

		public static readonly DebugUI.Widget.NameAndTooltip EnableLogging;

		public static readonly DebugUI.Widget.NameAndTooltip LogFrameInformation;

		public static readonly DebugUI.Widget.NameAndTooltip LogResources;
	}

	private DebugUI.Widget[] m_DebugItems;

	private DebugUI.Panel m_DebugPanel;

	public bool clearRenderTargetsAtCreation;

	public bool clearRenderTargetsAtRelease;

	public bool disablePassCulling;

	public bool immediateMode;

	public bool enableLogging;

	public bool logFrameInformation;

	public bool logResources;

	public void RegisterDebug(string name, DebugUI.Panel debugPanel = null)
	{
	}

	public void UnRegisterDebug(string name)
	{
	}
}
