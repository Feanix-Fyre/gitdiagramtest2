using System;

namespace Mono;

internal struct RuntimeEventHandle
{
	private IntPtr value;

	public IntPtr Value => (IntPtr)0;

	internal RuntimeEventHandle(IntPtr v)
	{
		value = (IntPtr)0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
