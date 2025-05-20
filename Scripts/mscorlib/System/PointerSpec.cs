using System.Text;

namespace System;

internal class PointerSpec : ModifierSpec
{
	private int pointer_level;

	internal PointerSpec(int pointer_level)
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
