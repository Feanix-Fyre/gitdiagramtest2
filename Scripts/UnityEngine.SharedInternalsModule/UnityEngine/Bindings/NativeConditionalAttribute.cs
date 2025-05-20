using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings;

[VisibleToOtherModules]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)]
internal class NativeConditionalAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CCondition_003Ek__BackingField;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CStubReturnStatement_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool _003CEnabled_003Ek__BackingField;

	public string Condition
	{
		[CompilerGenerated]
		set
		{
			_003CCondition_003Ek__BackingField = value;
		}
	}

	public string StubReturnStatement
	{
		[CompilerGenerated]
		set
		{
			_003CStubReturnStatement_003Ek__BackingField = value;
		}
	}

	public bool Enabled
	{
		[CompilerGenerated]
		set
		{
			_003CEnabled_003Ek__BackingField = value;
		}
	}

	public NativeConditionalAttribute(string condition)
	{
	}

	public NativeConditionalAttribute(string condition, string stubReturnStatement)
	{
	}
}
