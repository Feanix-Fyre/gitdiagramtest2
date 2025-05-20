using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
[NativeClass("BitField", "struct BitField;")]
[NativeHeader("Runtime/BaseClasses/BitField.h")]
public struct LayerMask
{
	[NativeName("m_Bits")]
	private int m_Mask;

	public int value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static implicit operator int(LayerMask mask)
	{
		return 0;
	}

	public static implicit operator LayerMask(int intVal)
	{
		return default(LayerMask);
	}

	[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
	[NativeMethod("LayerToString")]
	public static string LayerToName(int layer)
	{
		return null;
	}

	[StaticAccessor("GetTagManager()", StaticAccessorType.Dot)]
	[NativeMethod("StringToLayer")]
	public static int NameToLayer(string layerName)
	{
		return 0;
	}

	public static int GetMask(params string[] layerNames)
	{
		return 0;
	}
}
