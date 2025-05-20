using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class TextValueFieldTraits<TValueType, TValueUxmlAttributeType> : BaseFieldTraits<TValueType, TValueUxmlAttributeType> where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
{
	private UxmlBoolAttributeDescription m_IsReadOnly;

	private UxmlBoolAttributeDescription m_IsDelayed;

	public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
	{
	}
}
