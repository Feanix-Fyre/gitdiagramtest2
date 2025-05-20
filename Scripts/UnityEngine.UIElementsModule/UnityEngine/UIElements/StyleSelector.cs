using System;

namespace UnityEngine.UIElements;

[Serializable]
internal class StyleSelector
{
	[SerializeField]
	private StyleSelectorPart[] m_Parts;

	[SerializeField]
	private StyleSelectorRelationship m_PreviousRelationship;

	internal int pseudoStateMask;

	internal int negatedPseudoStateMask;

	public StyleSelectorPart[] parts
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public StyleSelectorRelationship previousRelationship
	{
		get
		{
			return default(StyleSelectorRelationship);
		}
		internal set
		{
		}
	}

	public override string ToString()
	{
		return null;
	}
}
