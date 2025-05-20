namespace UnityEngine.UIElements;

public class Foldout : BindableElement, INotifyValueChanged<bool>
{
	public new class UxmlFactory : UxmlFactory<Foldout, UxmlTraits>
	{
	}

	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		private UxmlStringAttributeDescription m_Text;

		private UxmlBoolAttributeDescription m_Value;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private Toggle m_Toggle;

	private VisualElement m_Container;

	[SerializeField]
	private bool m_Value;

	public static readonly string ussClassName;

	public static readonly string toggleUssClassName;

	public static readonly string contentUssClassName;

	public static readonly string inputUssClassName;

	public static readonly string checkmarkUssClassName;

	public static readonly string textUssClassName;

	internal static readonly string toggleInspectorUssClassName;

	internal static readonly string ussFoldoutDepthClassName;

	internal static readonly int ussFoldoutMaxDepth;

	private KeyboardNavigationManipulator m_NavigationManipulator;

	public override VisualElement contentContainer => null;

	public string text
	{
		set
		{
		}
	}

	public bool value
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetValueWithoutNotify(bool newValue)
	{
	}

	internal override void OnViewDataReady()
	{
	}

	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
	{
	}

	private bool Apply(KeyboardNavigationOperation op)
	{
		return false;
	}

	private void OnAttachToPanel(AttachToPanelEvent evt)
	{
	}
}
