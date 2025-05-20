using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
[VisibleToOtherModules]
internal sealed class NativeClassAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string _003CQualifiedNativeName_003Ek__BackingField;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CDeclaration_003Ek__BackingField;

	private string QualifiedNativeName
	{
		[CompilerGenerated]
		set
		{
			_003CQualifiedNativeName_003Ek__BackingField = value;
		}
	}

	private string Declaration
	{
		[CompilerGenerated]
		set
		{
			_003CDeclaration_003Ek__BackingField = value;
		}
	}

	public NativeClassAttribute(string qualifiedCppName)
	{
	}

	public NativeClassAttribute(string qualifiedCppName, string declaration)
	{
	}
}
