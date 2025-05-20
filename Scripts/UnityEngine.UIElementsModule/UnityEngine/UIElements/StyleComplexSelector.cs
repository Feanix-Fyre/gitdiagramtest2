using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

[Serializable]
internal class StyleComplexSelector : ISerializationCallbackReceiver
{
	private struct PseudoStateData
	{
		public readonly PseudoStates state;

		public readonly bool negate;

		public PseudoStateData(PseudoStates state, bool negate)
		{
			this.state = default(PseudoStates);
			this.negate = false;
		}
	}

	[NonSerialized]
	public Hashes ancestorHashes;

	[SerializeField]
	private int m_Specificity;

	[NonSerialized]
	private bool m_isSimple;

	[SerializeField]
	private StyleSelector[] m_Selectors;

	[SerializeField]
	internal int ruleIndex;

	[NonSerialized]
	internal StyleComplexSelector nextInTable;

	[NonSerialized]
	internal int orderInStyleSheet;

	private static Dictionary<string, PseudoStateData> s_PseudoStates;

	private static List<StyleSelectorPart> m_HashList;

	public int specificity => 0;

	public StyleRule rule { get; internal set; }

	public bool isSimple => false;

	public StyleSelector[] selectors
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public void OnBeforeSerialize()
	{
	}

	public virtual void OnAfterDeserialize()
	{
	}

	internal void CachePseudoStateMasks()
	{
	}

	public override string ToString()
	{
		return null;
	}

	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y)
	{
		return 0;
	}

	internal void CalculateHashes()
	{
	}
}
