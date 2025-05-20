using System;
using System.Reflection;

namespace Mono;

internal struct RuntimeGenericParamInfoHandle
{
	private unsafe RuntimeStructs.GenericParamInfo* value;

	internal Type[] Constraints => null;

	internal GenericParameterAttributes Attributes => default(GenericParameterAttributes);

	internal unsafe RuntimeGenericParamInfoHandle(IntPtr ptr)
	{
		value = null;
	}

	private Type[] GetConstraints()
	{
		return null;
	}

	private int GetConstraintsCount()
	{
		return 0;
	}
}
