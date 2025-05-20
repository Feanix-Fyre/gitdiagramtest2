using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PropertyName.h")]
internal class PropertyNameUtils
{
	[FreeFunction(IsThreadSafe = true)]
	public static PropertyName PropertyNameFromString([Unmarshalled] string name)
	{
		return default(PropertyName);
	}

	private static void PropertyNameFromString_Injected(string name, out PropertyName ret)
	{
		ret = default(PropertyName);
	}
}
