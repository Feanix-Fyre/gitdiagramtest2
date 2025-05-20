using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
internal class NativeThrowsAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CThrowsException_003Ek__BackingField;

	public bool ThrowsException
	{
		[CompilerGenerated]
		set
		{
			_003CThrowsException_003Ek__BackingField = value;
		}
	}
}
