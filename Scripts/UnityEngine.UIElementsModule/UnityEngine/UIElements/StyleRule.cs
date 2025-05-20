using System;

namespace UnityEngine.UIElements;

[Serializable]
internal class StyleRule
{
	[SerializeField]
	private StyleProperty[] m_Properties;

	[SerializeField]
	internal int line;

	[NonSerialized]
	internal int customPropertiesCount;

	public StyleProperty[] properties => null;
}
