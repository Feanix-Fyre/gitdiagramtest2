namespace UnityEngine.UIElements;

public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription<double>
{
	public override double GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return 0.0;
	}

	private static double ConvertValueToDouble(string v, double defaultValue)
	{
		return 0.0;
	}
}
