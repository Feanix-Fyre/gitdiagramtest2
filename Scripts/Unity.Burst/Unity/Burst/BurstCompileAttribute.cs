using System;

namespace Unity.Burst;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
public class BurstCompileAttribute : Attribute
{
	internal bool? _compileSynchronously;

	internal bool? _debug;

	internal bool? _disableSafetyChecks;

	internal bool? _disableDirectCall;

	public FloatMode FloatMode { get; set; }

	public FloatPrecision FloatPrecision { get; set; }

	public bool CompileSynchronously
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Debug
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DisableSafetyChecks
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DisableDirectCall
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public OptimizeFor OptimizeFor { get; set; }

	internal string[] Options { get; set; }

	public BurstCompileAttribute()
	{
	}

	public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode)
	{
	}

	internal BurstCompileAttribute(string[] options)
	{
	}
}
