using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class RectField : BaseCompositeField<Rect, FloatField, float>
{
	public new class UxmlFactory : UxmlFactory<RectField, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<Rect>.UxmlTraits
	{
		private UxmlFloatAttributeDescription m_XValue;

		private UxmlFloatAttributeDescription m_YValue;

		private UxmlFloatAttributeDescription m_WValue;

		private UxmlFloatAttributeDescription m_HValue;

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

	public RectField()
		: base((string)null, 0)
	{
	}

	public RectField(string label)
		: base((string)null, 0)
	{
	}
}
