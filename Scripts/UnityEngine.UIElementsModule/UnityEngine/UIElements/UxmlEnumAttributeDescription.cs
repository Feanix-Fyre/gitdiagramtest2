using System;

namespace UnityEngine.UIElements;

public class UxmlEnumAttributeDescription<T> : TypedUxmlAttributeDescription<T> where T : struct, IConvertible
{
	public override T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return default(T);
	}

	public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref T value)
	{
		return false;
	}

	private static U ConvertValueToEnum<U>(string v, U defaultValue) where U : struct
	{
		return default(U);
	}

	private static string GetEnumNameErrorMessage(string v, Type enumType)
	{
		return null;
	}

	private static string GetEnumRangeErrorMessage(string v, Type enumType)
	{
		return null;
	}
}
