namespace UnityEngine.UIElements;

public abstract class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription
{
	public T defaultValue { get; set; }

	public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);
}
