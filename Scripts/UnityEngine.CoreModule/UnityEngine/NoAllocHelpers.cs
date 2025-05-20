using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/NoAllocHelpers.bindings.h")]
internal sealed class NoAllocHelpers
{
	public static void ResizeList<T>(List<T> list, int size)
	{
	}

	public static void EnsureListElemCount<T>(List<T> list, int count)
	{
	}

	public static int SafeLength(Array values)
	{
		return 0;
	}

	public static int SafeLength<T>(List<T> values)
	{
		return 0;
	}

	public static T[] ExtractArrayFromListT<T>(List<T> list)
	{
		return null;
	}

	[FreeFunction("NoAllocHelpers_Bindings::Internal_ResizeList")]
	internal static void Internal_ResizeList(object list, int size)
	{
	}

	[FreeFunction("NoAllocHelpers_Bindings::ExtractArrayFromList")]
	public static Array ExtractArrayFromList(object list)
	{
		return null;
	}
}
