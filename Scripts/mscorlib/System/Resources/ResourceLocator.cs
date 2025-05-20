namespace System.Resources;

internal struct ResourceLocator
{
	internal object _value;

	internal int _dataPos;

	internal int DataPosition => 0;

	internal object Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ResourceLocator(int dataPos, object value)
	{
		_value = null;
		_dataPos = 0;
	}

	internal static bool CanCache(ResourceTypeCode value)
	{
		return false;
	}
}
