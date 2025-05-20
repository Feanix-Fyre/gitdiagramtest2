using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class LongField : TextValueField<long>
{
	public new class UxmlFactory : UxmlFactory<LongField, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextValueFieldTraits<long, UxmlLongAttributeDescription>
	{
	}

	private class LongInput : TextValueInput
	{
		private LongField parentLongField => null;

		protected override string allowedCharacters => null;

		internal LongInput()
		{
		}

		public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue)
		{
		}

		private long ClampMinMaxLongValue(long niceDelta, long value)
		{
			return 0L;
		}

		protected override string ValueToString(long v)
		{
			return null;
		}

		protected override long StringToValue(string str)
		{
			return 0L;
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	private LongInput longInput => null;

	protected override string ValueToString(long v)
	{
		return null;
	}

	protected override long StringToValue(string str)
	{
		return 0L;
	}

	public LongField()
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	public LongField(string label, int maxLength = 1000)
		: base((string)null, 0, (TextValueInput)null)
	{
	}

	internal override bool CanTryParse(string textString)
	{
		return false;
	}

	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, long startValue)
	{
	}
}
