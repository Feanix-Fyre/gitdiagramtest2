using System.Collections.Generic;

namespace UnityEngine.UIElements;

public class UxmlEnumeration : UxmlTypeRestriction
{
	private List<string> m_Values;

	public IEnumerable<string> values
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override bool Equals(UxmlTypeRestriction other)
	{
		return false;
	}
}
