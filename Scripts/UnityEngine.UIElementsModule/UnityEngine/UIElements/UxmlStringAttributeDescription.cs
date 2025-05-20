namespace UnityEngine.UIElements;

public class UxmlStringAttributeDescription : TypedUxmlAttributeDescription<string>
{
	public override string GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}

	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref string value)
	{
		return false;
	}
}
