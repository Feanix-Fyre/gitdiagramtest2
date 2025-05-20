using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector4Field : BaseCompositeField<Vector4, FloatField, float>
{
	public new class UxmlFactory : UxmlFactory<Vector4Field, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<Vector4>.UxmlTraits
	{
		private UxmlFloatAttributeDescription m_XValue;

		private UxmlFloatAttributeDescription m_YValue;

		private UxmlFloatAttributeDescription m_ZValue;

		private UxmlFloatAttributeDescription m_WValue;

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

	public Vector4Field()
		: base((string)null, 0)
	{
	}

	public Vector4Field(string label)
		: base((string)null, 0)
	{
	}
}
