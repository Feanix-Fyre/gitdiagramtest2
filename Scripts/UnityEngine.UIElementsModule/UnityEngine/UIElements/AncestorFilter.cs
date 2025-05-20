using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class AncestorFilter
{
	private CountingBloomFilter m_CountingBloomFilter;

	private Stack<int> m_HashStack;

	private void AddHash(int hash)
	{
	}

	public bool IsCandidate(StyleComplexSelector complexSel)
	{
		return false;
	}

	public void PushElement(VisualElement element)
	{
	}

	public void PopElement()
	{
	}
}
