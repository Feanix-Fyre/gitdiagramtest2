using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class IntegerField : TextValueField<int>
{
	public new class UxmlFactory : UxmlFactory<IntegerField, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextValueFieldTraits<int, UxmlIntAttributeDescription>
	{
	}

	private class IntegerInput : TextValueInput
	{
		private IntegerField parentIntegerField => null;

		protected override string allowedCharacters => null;

		internal IntegerInput()
		{
		}

		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue)
		{
		}

		protected override string ValueToString(int v)
		{
			return null;
		}

		protected override int StringToValue(string str)
		{
			return 0;
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	private IntegerInput integerInput => null;

	protected override string ValueToString(int v)
	{
		return null;
	}

	protected override int StringToValue(string str)
	{
		return 0;
	}

	public IntegerField()
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	public IntegerField(string label, int maxLength = 1000)
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	internal override bool CanTryParse(string textString)
	{
		return false;
	}

	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue)
	{
	}
}
