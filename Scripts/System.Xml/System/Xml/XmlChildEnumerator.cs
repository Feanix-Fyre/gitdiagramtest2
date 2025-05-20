using System.Collections;

namespace System.Xml;

internal sealed class XmlChildEnumerator : IEnumerator
{
	internal XmlNode container;

	internal XmlNode child;

	internal bool isFirst;

	object IEnumerator.Current => null;

	internal XmlNode Current => null;

	internal XmlChildEnumerator(XmlNode container)
	{
	}

	bool IEnumerator.MoveNext()
	{
		return false;
	}

	internal bool MoveNext()
	{
		return false;
	}

	void IEnumerator.Reset()
	{
	}
}
