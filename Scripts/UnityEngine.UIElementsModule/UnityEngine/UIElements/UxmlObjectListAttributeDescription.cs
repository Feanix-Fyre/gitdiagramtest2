using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class UxmlObjectListAttributeDescription<T> : UxmlObjectAttributeDescription<List<T>> where T : new()
{
	public override List<T> GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return null;
	}
}
