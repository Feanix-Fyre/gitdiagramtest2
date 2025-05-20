namespace UnityEngine.UIElements;

public class UxmlUnsignedLongAttributeDescription : TypedUxmlAttributeDescription<ulong>
{
	public override ulong GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return 0uL;
	}

	private static ulong ConvertValueToUlong(string v, ulong defaultValue)
	{
		return 0uL;
	}
}
