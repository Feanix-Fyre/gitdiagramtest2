namespace UnityEngine.UIElements;

public class UnsignedLongField : TextValueField<ulong>
{
	public new class UxmlFactory : UxmlFactory<UnsignedLongField, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextValueFieldTraits<ulong, UxmlUnsignedLongAttributeDescription>
	{
	}

	private class UnsignedLongInput : TextValueInput
	{
		private UnsignedLongField parentUnsignedLongField => null;

		protected override string allowedCharacters => null;

		internal UnsignedLongInput()
		{
		}

		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue)
		{
		}

		private ulong ClampToMinMaxULongValue(long niceDelta, ulong value)
		{
			return 0uL;
		}

		protected override string ValueToString(ulong v)
		{
			return null;
		}

		protected override ulong StringToValue(string str)
		{
			return 0uL;
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	private UnsignedLongInput unsignedLongInput => null;

	protected override string ValueToString(ulong v)
	{
		return null;
	}

	protected override ulong StringToValue(string str)
	{
		return 0uL;
	}

	public UnsignedLongField()
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	public UnsignedLongField(string label, int maxLength = 1000)
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	internal override bool CanTryParse(string textString)
	{
		return false;
	}

	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, ulong startValue)
	{
	}
}
