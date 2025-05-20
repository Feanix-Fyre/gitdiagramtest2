using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Bindings;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum)]
[VisibleToOtherModules]
internal class NativeTypeAttribute : Attribute
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CHeader_003Ek__BackingField;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CIntermediateScriptingStructName_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private CodegenOptions _003CCodegenOptions_003Ek__BackingField;

	public string Header
	{
		[CompilerGenerated]
		set
		{
			_003CHeader_003Ek__BackingField = value;
		}
	}

	public string IntermediateScriptingStructName
	{
		[CompilerGenerated]
		set
		{
			_003CIntermediateScriptingStructName_003Ek__BackingField = value;
		}
	}

	public CodegenOptions CodegenOptions
	{
		[CompilerGenerated]
		set
		{
			_003CCodegenOptions_003Ek__BackingField = value;
		}
	}

	public NativeTypeAttribute()
	{
	}

	public NativeTypeAttribute(CodegenOptions codegenOptions)
	{
	}

	public NativeTypeAttribute(string header)
	{
	}

	public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
	{
	}
}
