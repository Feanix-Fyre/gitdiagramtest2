using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector3Field : BaseCompositeField<Vector3, FloatField, float>
{
	public new class UxmlFactory : UxmlFactory<Vector3Field, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<Vector3>.UxmlTraits
	{
		private UxmlFloatAttributeDescription m_XValue;

		private UxmlFloatAttributeDescription m_YValue;

		private UxmlFloatAttributeDescription m_ZValue;

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

	public Vector3Field()
		: base((string)null, 0)
	{
	}

	public Vector3Field(string label)
		: base((string)null, 0)
	{
	}
}
