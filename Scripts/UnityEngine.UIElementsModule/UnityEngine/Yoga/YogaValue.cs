namespace UnityEngine.Yoga;

internal struct YogaValue
{
	private float value;

	private YogaUnit unit;

	public YogaUnit Unit => default(YogaUnit);

	public float Value => 0f;

	public static YogaValue Point(float value)
	{
		return default(YogaValue);
	}

	public bool Equals(YogaValue other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static YogaValue Auto()
	{
		return default(YogaValue);
	}

	public static YogaValue Percent(float value)
	{
		return default(YogaValue);
	}

	public static implicit operator YogaValue(float pointValue)
	{
		return default(YogaValue);
	}
}
