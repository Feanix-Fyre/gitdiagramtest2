namespace UnityEngine.UIElements;

public class UxmlIntAttributeDescription : TypedUxmlAttributeDescription<int>
{
	public override int GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return 0;
	}

	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref int value)
	{
		return false;
	}

	private static int ConvertValueToInt(string v, int defaultValue)
	{
		return 0;
	}
}
