using System.Collections.Generic;

namespace System.Dynamic;

internal class ExpandoClass
{
	private readonly string[] _keys;

	private readonly int _hashCode;

	private Dictionary<int, List<WeakReference>> _transitions;

	internal static readonly ExpandoClass Empty;

	internal string[] Keys => null;

	internal ExpandoClass()
	{
	}

	internal ExpandoClass(string[] keys, int hashCode)
	{
	}

	internal ExpandoClass FindNewClass(string newKey)
	{
		return null;
	}

	private List<WeakReference> GetTransitionList(int hashCode)
	{
		return null;
	}

	internal int GetValueIndex(string name, bool caseInsensitive, ExpandoObject obj)
	{
		return 0;
	}

	internal int GetValueIndexCaseSensitive(string name)
	{
		return 0;
	}

	private int GetValueIndexCaseInsensitive(string name, ExpandoObject obj)
	{
		return 0;
	}
}
