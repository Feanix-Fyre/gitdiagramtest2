using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
internal class NativeMethodAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CName_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsThreadSafe_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CIsFreeFunction_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CThrowsException_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CHasExplicitThis_003Ek__BackingField;

	public string Name
	{
		[CompilerGenerated]
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public bool IsThreadSafe
	{
		[CompilerGenerated]
		set
		{
			_003CIsThreadSafe_003Ek__BackingField = value;
		}
	}

	public bool IsFreeFunction
	{
		[CompilerGenerated]
		set
		{
			_003CIsFreeFunction_003Ek__BackingField = value;
		}
	}

	public bool ThrowsException
	{
		[CompilerGenerated]
		set
		{
			_003CThrowsException_003Ek__BackingField = value;
		}
	}

	public bool HasExplicitThis
	{
		[CompilerGenerated]
		set
		{
			_003CHasExplicitThis_003Ek__BackingField = value;
		}
	}

	public NativeMethodAttribute()
	{
	}

	public NativeMethodAttribute(string name)
	{
	}

	public NativeMethodAttribute(string name, bool isFreeFunction)
	{
	}

	public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe)
	{
	}
}
