using System.Runtime.InteropServices;

namespace System;

/// <summary>Represents a variable-length argument list; that is, the parameters of a function that takes a variable number of arguments.</summary>
[StructLayout((LayoutKind)3)]
public struct ArgIterator
{
	private IntPtr sig;

	private IntPtr args;

	private int next_arg;

	private int num_args;

	/// <summary>This method is not supported, and always throws <see cref="T:System.NotSupportedException" />.</summary>
	/// <param name="o">An object to be compared to this instance.</param>
	/// <returns>This comparison is not supported. No value is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override bool Equals(object o)
	{
		return false;
	}

	/// <summary>Returns the hash code of this object.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
