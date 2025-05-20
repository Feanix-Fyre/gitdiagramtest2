namespace UnityEngine.UIElements;

public class UnsignedIntegerField : TextValueField<uint>
{
	public new class UxmlFactory : UxmlFactory<UnsignedIntegerField, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextValueFieldTraits<uint, UxmlUnsignedIntAttributeDescription>
	{
	}

	private class UnsignedIntegerInput : TextValueInput
	{
		private UnsignedIntegerField parentUnsignedIntegerField => null;

		protected override string allowedCharacters => null;

		internal UnsignedIntegerInput()
		{
		}

		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue)
		{
		}

		protected override string ValueToString(uint v)
		{
			return null;
		}

		protected override uint StringToValue(string str)
		{
			return 0u;
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	private UnsignedIntegerInput integerInput => null;

	protected override string ValueToString(uint v)
	{
		return null;
	}

	protected override uint StringToValue(string str)
	{
		return 0u;
	}

	public UnsignedIntegerField()
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	public UnsignedIntegerField(string label, int maxLength = 1000)
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	internal override bool CanTryParse(string textString)
	{
		return false;
	}

	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, uint startValue)
	{
	}
}
