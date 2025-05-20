using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class DoubleField : TextValueField<double>
{
	public new class UxmlFactory : UxmlFactory<DoubleField, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextValueFieldTraits<double, UxmlDoubleAttributeDescription>
	{
	}

	private class DoubleInput : TextValueInput
	{
		private DoubleField parentDoubleField => null;

		protected override string allowedCharacters => null;

		internal DoubleInput()
		{
		}

		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue)
		{
		}

		protected override string ValueToString(double v)
		{
			return null;
		}

		protected override double StringToValue(string str)
		{
			return 0.0;
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	private DoubleInput doubleInput => null;

	protected override string ValueToString(double v)
	{
		return null;
	}

	protected override double StringToValue(string str)
	{
		return 0.0;
	}

	public DoubleField()
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	public DoubleField(string label, int maxLength = 1000)
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	internal override bool CanTryParse(string textString)
	{
		return false;
	}

	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, double startValue)
	{
	}
}
