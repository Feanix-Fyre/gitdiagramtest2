using System;

namespace UnityEngine.UIElements;

[Serializable]
internal struct StyleValueHandle
{
	[SerializeField]
	private StyleValueType m_ValueType;

	[SerializeField]
	internal int valueIndex;

	public StyleValueType valueType
	{
		get
		{
			return default(StyleValueType);
		}
		internal set
		{
		}
	}
}
