using System;

namespace UnityEngine.UIElements;

[Serializable]
internal class StyleProperty
{
	[SerializeField]
	private string m_Name;

	[SerializeField]
	private int m_Line;

	[SerializeField]
	private StyleValueHandle[] m_Values;

	[NonSerialized]
	internal bool isCustomProperty;

	[NonSerialized]
	internal bool requireVariableResolve;

	public string name => null;

	public StyleValueHandle[] values => null;
}
