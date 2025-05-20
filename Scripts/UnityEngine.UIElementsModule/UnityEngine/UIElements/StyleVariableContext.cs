using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class StyleVariableContext
{
	public static readonly StyleVariableContext none;

	private int m_VariableHash;

	private List<StyleVariable> m_Variables;

	private List<int> m_SortedHash;

	private List<int> m_UnsortedHash;

	public void Add(StyleVariable sv)
	{
	}

	public void AddInitialRange(StyleVariableContext other)
	{
	}

	public void Clear()
	{
	}

	public StyleVariableContext()
	{
	}

	public StyleVariableContext(StyleVariableContext other)
	{
	}

	public bool TryFindVariable(string name, out StyleVariable v)
	{
		v = default(StyleVariable);
		return false;
	}

	public int GetVariableHash()
	{
		return 0;
	}
}
