namespace UnityEngine.UIElements;

internal class UxmlObjectAttributeDescription<T> where T : new()
{
	public T defaultValue { get; }

	public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return default(T);
	}
}
