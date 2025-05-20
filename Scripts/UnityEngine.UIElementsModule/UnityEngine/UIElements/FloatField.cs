using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class FloatField : TextValueField<float>
{
	public new class UxmlFactory : UxmlFactory<FloatField, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextValueFieldTraits<float, UxmlFloatAttributeDescription>
	{
	}

	private class FloatInput : TextValueInput
	{
		private FloatField parentFloatField => null;

		protected override string allowedCharacters => null;

		internal FloatInput()
		{
		}

		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue)
		{
		}

		protected override string ValueToString(float v)
		{
			return null;
		}

		protected override float StringToValue(string str)
		{
			return 0f;
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	private FloatInput floatInput => null;

	protected override string ValueToString(float v)
	{
		return null;
	}

	protected override float StringToValue(string str)
	{
		return 0f;
	}

	public FloatField()
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	public FloatField(string label, int maxLength = 1000)
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	internal override bool CanTryParse(string textString)
	{
		return false;
	}

	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, float startValue)
	{
	}
}
