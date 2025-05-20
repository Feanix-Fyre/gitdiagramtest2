using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class CreateAssetMenuAttribute : Attribute
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CmenuName_003Ek__BackingField;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CfileName_003Ek__BackingField;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int _003Corder_003Ek__BackingField;

	public string menuName
	{
		[CompilerGenerated]
		set
		{
			_003CmenuName_003Ek__BackingField = value;
		}
	}

	public string fileName
	{
		[CompilerGenerated]
		set
		{
			_003CfileName_003Ek__BackingField = value;
		}
	}

	public int order
	{
		[CompilerGenerated]
		set
		{
			_003Corder_003Ek__BackingField = value;
		}
	}
}
