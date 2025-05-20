using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Field)]
[VisibleToOtherModules]
internal class IgnoreAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CDoesNotContributeToSize_003Ek__BackingField;

	public bool DoesNotContributeToSize
	{
		[CompilerGenerated]
		set
		{
			_003CDoesNotContributeToSize_003Ek__BackingField = value;
		}
	}
}
