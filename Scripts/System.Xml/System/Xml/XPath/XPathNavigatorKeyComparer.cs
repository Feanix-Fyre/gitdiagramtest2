using System.Collections;

namespace System.Xml.XPath;

internal class XPathNavigatorKeyComparer : IEqualityComparer
{
	bool IEqualityComparer.Equals(object obj1, object obj2)
	{
		return false;
	}

	int IEqualityComparer.GetHashCode(object obj)
	{
		return 0;
	}
}
