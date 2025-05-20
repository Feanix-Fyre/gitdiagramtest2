namespace UnityEngine.UIElements;

public class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : BaseField<TValueType>.UxmlTraits where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
{
	private TValueUxmlAttributeType m_Value;

	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
	{
	}
}
