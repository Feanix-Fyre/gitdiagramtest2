using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector2IntField : BaseCompositeField<Vector2Int, IntegerField, int>
{
	public new class UxmlFactory : UxmlFactory<Vector2IntField, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<Vector2Int>.UxmlTraits
	{
		private UxmlIntAttributeDescription m_XValue;

		private UxmlIntAttributeDescription m_YValue;

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

	public Vector2IntField()
		: base((string)null, 0)
	{
	}

	public Vector2IntField(string label)
		: base((string)null, 0)
	{
	}
}
