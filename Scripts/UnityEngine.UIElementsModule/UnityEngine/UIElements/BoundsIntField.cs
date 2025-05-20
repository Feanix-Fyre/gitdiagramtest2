using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class BoundsIntField : BaseField<BoundsInt>
{
	public new class UxmlFactory : UxmlFactory<BoundsIntField, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<BoundsInt>.UxmlTraits
	{
		private UxmlIntAttributeDescription m_PositionXValue;

		private UxmlIntAttributeDescription m_PositionYValue;

		private UxmlIntAttributeDescription m_PositionZValue;

		private UxmlIntAttributeDescription m_SizeXValue;

		private UxmlIntAttributeDescription m_SizeYValue;

		private UxmlIntAttributeDescription m_SizeZValue;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private Vector3IntField m_PositionField;

	private Vector3IntField m_SizeField;

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	public static readonly string positionUssClassName;

	public static readonly string sizeUssClassName;

	public BoundsIntField()
		: base((string)null)
	{
	}

	public BoundsIntField(string label)
		: base((string)null)
	{
	}

	public override void SetValueWithoutNotify(BoundsInt newValue)
	{
	}

	protected override void UpdateMixedValueContent()
	{
	}
}
