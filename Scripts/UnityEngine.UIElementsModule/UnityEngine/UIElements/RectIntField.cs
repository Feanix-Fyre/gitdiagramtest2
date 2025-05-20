using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class RectIntField : BaseCompositeField<RectInt, IntegerField, int>
{
	public new class UxmlFactory : UxmlFactory<RectIntField, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<RectInt>.UxmlTraits
	{
		private UxmlIntAttributeDescription m_XValue;

		private UxmlIntAttributeDescription m_YValue;

		private UxmlIntAttributeDescription m_WValue;

		private UxmlIntAttributeDescription m_HValue;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	internal override FieldDescription[] DescribeFields()
	{
		return null;
	}

	public RectIntField()
		: base((string)null, 0)
	{
	}

	public RectIntField(string label)
		: base((string)null, 0)
	{
	}
}
