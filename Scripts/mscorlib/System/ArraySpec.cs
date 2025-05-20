using System.Text;

namespace System;

internal class ArraySpec : ModifierSpec
{
	private int dimensions;

	private bool bound;

	internal ArraySpec(int dimensions, bool bound)
	{
	}

	public Type Resolve(Type type)
	{
		return null;
	}

	public StringBuilder Append(StringBuilder sb)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
