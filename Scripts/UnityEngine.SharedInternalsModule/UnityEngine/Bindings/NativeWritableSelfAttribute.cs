using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Method)]
internal sealed class NativeWritableSelfAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CWritableSelf_003Ek__BackingField;

	public bool WritableSelf
	{
		[CompilerGenerated]
		set
		{
			_003CWritableSelf_003Ek__BackingField = value;
		}
	}
}
