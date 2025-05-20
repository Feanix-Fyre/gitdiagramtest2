namespace UnityEngine.UIElements;

public class DropdownField : PopupField<string>
{
	public new class UxmlFactory : UxmlFactory<DropdownField, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<string>.UxmlTraits
	{
		private UxmlIntAttributeDescription m_Index;

		private UxmlStringAttributeDescription m_Choices;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public DropdownField()
		: base((string)null)
	{
	}

	public DropdownField(string label)
		: base((string)null)
	{
	}
}
