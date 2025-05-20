namespace System;

internal readonly struct ParamsArray
{
	private static readonly object[] s_oneArgArray;

	private static readonly object[] s_twoArgArray;

	private static readonly object[] s_threeArgArray;

	private readonly object _arg0;

	private readonly object _arg1;

	private readonly object _arg2;

	private readonly object[] _args;

	public int Length => 0;

	public object this[int index] => null;

	public ParamsArray(object arg0)
	{
		_arg0 = null;
		_arg1 = null;
		_arg2 = null;
		_args = null;
	}

	public ParamsArray(object arg0, object arg1)
	{
		_arg0 = null;
		_arg1 = null;
		_arg2 = null;
		_args = null;
	}

	public ParamsArray(object arg0, object arg1, object arg2)
	{
		_arg0 = null;
		_arg1 = null;
		_arg2 = null;
		_args = null;
	}

	public ParamsArray(object[] args)
	{
		_arg0 = null;
		_arg1 = null;
		_arg2 = null;
		_args = null;
	}

	private object GetAtSlow(int index)
	{
		return null;
	}
}
