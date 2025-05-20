using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements;

[Serializable]
internal class TemplateAsset : VisualElementAsset
{
	[Serializable]
	public struct AttributeOverride
	{
		public string m_ElementName;

		public string m_AttributeName;

		public string m_Value;
	}

	[SerializeField]
	private string m_TemplateAlias;

	[SerializeField]
	private List<AttributeOverride> m_AttributeOverrides;

	[SerializeField]
	private List<VisualTreeAsset.SlotUsageEntry> m_SlotUsages;

	public List<AttributeOverride> attributeOverrides => null;

	internal List<VisualTreeAsset.SlotUsageEntry> slotUsages => null;
}
