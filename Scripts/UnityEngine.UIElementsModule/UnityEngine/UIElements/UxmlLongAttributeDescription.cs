namespace UnityEngine.UIElements;

public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long>
{
	public override long GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return 0L;
	}

	private static long ConvertValueToLong(string v, long defaultValue)
	{
		return 0L;
	}
}
