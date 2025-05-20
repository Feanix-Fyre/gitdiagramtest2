namespace UnityEngine.UIElements;

public class UxmlBoolAttributeDescription : TypedUxmlAttributeDescription<bool>
{
	public override bool GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return false;
	}

	private static bool ConvertValueToBool(string v, bool defaultValue)
	{
		return false;
	}
}
