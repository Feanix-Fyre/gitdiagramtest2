using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Property)]
[VisibleToOtherModules]
internal class NativePropertyAttribute : NativeMethodAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TargetType _003CTargetType_003Ek__BackingField;

	public TargetType TargetType
	{
		[CompilerGenerated]
		set
		{
			_003CTargetType_003Ek__BackingField = value;
		}
	}

	public NativePropertyAttribute()
	{
	}

	public NativePropertyAttribute(string name)
	{
	}

	public NativePropertyAttribute(string name, bool isFree, TargetType targetType)
	{
	}

	public NativePropertyAttribute(string name, bool isFree, TargetType targetType, bool isThreadSafe)
	{
	}
}
