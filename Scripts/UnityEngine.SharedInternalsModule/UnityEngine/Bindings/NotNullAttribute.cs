using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Parameter)]
internal class NotNullAttribute : Attribute
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CException_003Ek__BackingField;

	public string Exception
	{
		[CompilerGenerated]
		set
		{
			_003CException_003Ek__BackingField = value;
		}
	}

	public NotNullAttribute(string exception = "ArgumentNullException")
	{
	}
}
