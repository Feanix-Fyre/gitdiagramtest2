namespace UnityEngine.UIElements;

public class UxmlUnsignedIntAttributeDescription : TypedUxmlAttributeDescription<uint>
{
	public override uint GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return 0u;
	}

	private static uint ConvertValueToUInt(string v, uint defaultValue)
	{
		return 0u;
	}
}
