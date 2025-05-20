namespace UnityEngine.UIElements;

internal class RuntimePanel : BaseRuntimePanel
{
	internal static readonly EventDispatcher s_EventDispatcher;

	private readonly PanelSettings m_PanelSettings;

	public PanelSettings panelSettings => null;

	public static RuntimePanel Create(ScriptableObject ownerObject)
	{
		return null;
	}

	private RuntimePanel(ScriptableObject ownerObject)
		: base(null)
	{
	}

	public override void Update()
	{
	}

	private void OnElementFocus(FocusEvent evt)
	{
	}
}
