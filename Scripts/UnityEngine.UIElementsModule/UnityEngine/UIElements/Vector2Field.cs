using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class Vector2Field : BaseCompositeField<Vector2, FloatField, float>
{
	public new class UxmlFactory : UxmlFactory<Vector2Field, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
	{
		private UxmlFloatAttributeDescription m_XValue;

		private UxmlFloatAttributeDescription m_YValue;

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

	public Vector2Field()
		: base((string)null, 0)
	{
	}

	public Vector2Field(string label)
		: base((string)null, 0)
	{
	}
}
