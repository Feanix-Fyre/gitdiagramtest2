using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

[Serializable]
internal class UxmlAsset : IUxmlAttributes
{
	[SerializeField]
	private string m_FullTypeName;

	[SerializeField]
	private int m_Id;

	[SerializeField]
	private int m_OrderInDocument;

	[SerializeField]
	private int m_ParentId;

	[SerializeField]
	protected List<string> m_Properties;

	public string fullTypeName => null;

	public int id => 0;

	public int orderInDocument => 0;

	public int parentId => 0;

	public bool TryGetAttributeValue(string propertyName, out string value)
	{
		value = null;
		return false;
	}

	public void SetAttribute(string name, string value)
	{
	}

	private void SetOrAddProperty(string propertyName, string propertyValue)
	{
	}
}
