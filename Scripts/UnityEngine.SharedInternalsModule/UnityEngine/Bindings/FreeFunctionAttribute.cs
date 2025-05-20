using System;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Method)]
[VisibleToOtherModules]
internal class FreeFunctionAttribute : NativeMethodAttribute
{
	public FreeFunctionAttribute()
	{
	}

	public FreeFunctionAttribute(string name)
	{
	}

	public FreeFunctionAttribute(string name, bool isThreadSafe)
	{
	}
}
