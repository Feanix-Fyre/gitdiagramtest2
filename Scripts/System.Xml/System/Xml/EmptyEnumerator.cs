using System.Collections;

namespace System.Xml;

internal sealed class EmptyEnumerator : IEnumerator
{
	object IEnumerator.Current => null;

	bool IEnumerator.MoveNext()
	{
		return false;
	}

	void IEnumerator.Reset()
	{
	}
}
