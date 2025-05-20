namespace UnityEngine.UIElements;

public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<float>
{
	public override float GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return 0f;
	}

	private static float ConvertValueToFloat(string v, float defaultValue)
	{
		return 0f;
	}
}
