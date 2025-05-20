using System.Collections;
using System.Globalization;

namespace System;

[Serializable]
internal class InvariantComparer : IComparer
{
	private CompareInfo m_compareInfo;

	internal static readonly InvariantComparer Default;

	internal InvariantComparer()
	{
	}

	public int Compare(object a, object b)
	{
		return 0;
	}
}
