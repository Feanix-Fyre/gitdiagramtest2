using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector3IntField : BaseCompositeField<Vector3Int, IntegerField, int>
{
	public new class UxmlFactory : UxmlFactory<Vector3IntField, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<Vector3Int>.UxmlTraits
	{
		private UxmlIntAttributeDescription m_XValue;

		private UxmlIntAttributeDescription m_YValue;

		private UxmlIntAttributeDescription m_ZValue;

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

	public Vector3IntField()
		: base((string)null, 0)
	{
	}

	public Vector3IntField(string label)
		: base((string)null, 0)
	{
	}
}
