using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class BoundsField : BaseField<Bounds>
{
	public new class UxmlFactory : UxmlFactory<BoundsField, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<Bounds>.UxmlTraits
	{
		private UxmlFloatAttributeDescription m_CenterXValue;

		private UxmlFloatAttributeDescription m_CenterYValue;

		private UxmlFloatAttributeDescription m_CenterZValue;

		private UxmlFloatAttributeDescription m_ExtentsXValue;

		private UxmlFloatAttributeDescription m_ExtentsYValue;

		private UxmlFloatAttributeDescription m_ExtentsZValue;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	public static readonly string centerFieldUssClassName;

	public static readonly string extentsFieldUssClassName;

	private Vector3Field m_CenterField;

	private Vector3Field m_ExtentsField;

	public BoundsField()
		: base((string)null)
	{
	}

	public BoundsField(string label)
		: base((string)null)
	{
	}

	public override void SetValueWithoutNotify(Bounds newValue)
	{
	}

	protected override void UpdateMixedValueContent()
	{
	}
}
