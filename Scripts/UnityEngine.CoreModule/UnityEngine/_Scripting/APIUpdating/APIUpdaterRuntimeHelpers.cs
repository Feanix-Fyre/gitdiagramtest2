using System;
using UnityEngine.Scripting;

namespace UnityEngine._Scripting.APIUpdating;

internal class APIUpdaterRuntimeHelpers
{
	[RequiredByNativeCode]
	internal static bool GetMovedFromAttributeDataForType(Type sourceType, out string assembly, out string nsp, out string klass)
	{
		assembly = null;
		nsp = null;
		klass = null;
		return false;
	}

	[RequiredByNativeCode]
	internal static bool GetObsoleteTypeRedirection(Type sourceType, out string assemblyName, out string nsp, out string className)
	{
		assemblyName = null;
		nsp = null;
		className = null;
		return false;
	}
}
